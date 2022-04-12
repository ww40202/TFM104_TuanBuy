using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.Ocsp;
using StackExchange.Redis;
using Topic.Hubs;
using TuanBuy.Models.Entities;
using TuanBuy.ViewModel;

namespace TuanBuy.Controllers
{
    public class DemoController : Controller
    {
        private readonly TuanBuyContext _dbContext;
        private readonly IWebHostEnvironment _environment;
        private static IDistributedCache _distributedCache;

        public DemoController(TuanBuyContext context, IWebHostEnvironment environment, IDistributedCache distributedCache)
        {
            _dbContext = context;
            _environment = environment;
            _distributedCache= distributedCache;
        }

        public IActionResult Index()
        {

            return View();


        }

        public object GetRedis()
        {
            var claim = HttpContext.User.Claims;
            var userEmail = claim.FirstOrDefault(a => a.Type == ClaimTypes.Email)?.Value;
            var targetUser = _dbContext.User.FirstOrDefault(x => x.Email == userEmail);
            var a = JsonConvert.DeserializeObject(_distributedCache.GetString(targetUser.Id.ToString()));
           return a.ToString();
        }
        public class UserModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }





        private void CheckJsonSerialization()
        {
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            writer.WriteLine("Test string");
            writer.Flush();
            ms.Position = 0;

            var json = JsonConvert.SerializeObject(ms, Formatting.Indented, new MemoryStreamJsonConverter());
            var ms2 = JsonConvert.DeserializeObject<MemoryStream>(json, new MemoryStreamJsonConverter());
            var reader = new StreamReader(ms2);
            var deserializedString = reader.ReadLine();

            Console.Write(json);
            Console.Write(deserializedString);
            Console.Read();
        }

        public class ClassToCheckSerialization
        {
            public string StringProperty { get; set; }

            [JsonConverter(typeof(MemoryStreamJsonConverter))]
            public Stream StreamProperty { get; set; }
        }
        private void CheckJsonSerializationOfClass()
        {
            var data = new ClassToCheckSerialization();
            var ms = new MemoryStream();
            const string entryString = "Test string inside stream";
            var sw = new StreamWriter(ms);
            sw.WriteLine(entryString);
            sw.Flush();
            ms.Position = 0;
            data.StreamProperty = ms;
            var json = JsonConvert.SerializeObject(data);

            var result = JsonConvert.DeserializeObject<ClassToCheckSerialization>(json);
            var sr = new StreamReader(result.StreamProperty);
            var stringRead = sr.ReadLine();
            //Assert.AreEqual(entryString, stringRead);
        }

        public class MemoryStreamJsonConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return typeof(MemoryStream).IsAssignableFrom(objectType);
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                var bytes = serializer.Deserialize<byte[]>(reader);
                return bytes != null ? new MemoryStream(bytes) : new MemoryStream();
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                var bytes = ((MemoryStream)value).ToArray();
                serializer.Serialize(writer, bytes);
            }
        }
        #region 暫時用不到
        public string DemoUrl()
        {
            string url = _environment.WebRootPath;

            return url;

        }
        public List<OrderViewModel> GetMyOrder(int id)
        {
            //撈出使用者訂單
            var orders =
                (from order in _dbContext.Order
                 where order.UserId == id
                 join orderDetail in _dbContext.OrderDetail on order.Id equals orderDetail.OrderId
                 join product in _dbContext.Product on orderDetail.ProductId equals product.Id
                 join seller in _dbContext.User on product.UserId equals seller.Id
                 select new { order, product, orderDetail, seller }).ToList();
            //拿使用者訂單去找每個產品的圖片
            var productPics =
                    from myOrderDetail in orders
                    join pic in _dbContext.ProductPics on myOrderDetail.product.Id equals pic.ProductId into pics
                    select new { myOrderDetail, pic = pics.First() };

            var myOrderDetails = new List<OrderViewModel>();

            foreach (var item in productPics)
            {
                var myOrderDetail = new OrderViewModel()
                {
                    OrderId = item.myOrderDetail.order.Id,
                    OrderState = item.myOrderDetail.order.StateId,
                    Description = item.myOrderDetail.order.Description,
                    Count = item.myOrderDetail.orderDetail.Count,
                    PaymentType = item.myOrderDetail.order.PaymentType,
                    Address = item.myOrderDetail.order.Address,
                    SellerId = item.myOrderDetail.seller.Id,
                    SellerName = item.myOrderDetail.seller.Name,
                    ProductName = item.myOrderDetail.product.Name,
                    ProductDescription = item.myOrderDetail.product.Description,
                    ProductPrice = item.myOrderDetail.product.Price,
                    ProductId = item.myOrderDetail.product.Id
                };
                if (item.myOrderDetail.product.Id == item.pic.ProductId)
                {
                    myOrderDetail.ProductPath = item.pic.PicPath;
                }
                myOrderDetails.Add(myOrderDetail);
            }
            return myOrderDetails;

        }


        #endregion


    }
}