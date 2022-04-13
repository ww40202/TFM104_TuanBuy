using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;
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
using TuanBuy.Models.AppUtlity;
using TuanBuy.Models.Entities;
using TuanBuy.ViewModel;

namespace TuanBuy.Controllers
{
    public class DemoController : Controller
    {
        private readonly TuanBuyContext _dbContext;
        private readonly IWebHostEnvironment _environment;
        private static IDistributedCache _distributedCache;
        private readonly RedisProvider _mydb;

        public DemoController(TuanBuyContext context, IWebHostEnvironment environment, IDistributedCache distributedCache, RedisProvider Mydb)
        {
            _dbContext = context;
            _environment = environment;
            _distributedCache = distributedCache;
            _mydb = Mydb;
        }

        public class Users {
            public string Name { get; set; }
            public int Age { get; set; }
        }


        public IActionResult Index()
        {

            var user = new Users() {Name = "小王", Age = 20};
            var json = JsonConvert.SerializeObject(user);
            var bytes = Encoding.UTF8.GetBytes(json);
            _distributedCache.Set("test",bytes);

            var a =Encoding.UTF8.GetString(_distributedCache.Get("test"));
            var yes =JsonConvert.DeserializeObject<Users>(a);

            var db = _mydb.GetRedisDb(0);
          var ricoID = "1";

            db.HashSet(ricoID, RedisProvider.ToHashEntries(user));

            var c = db.HashGetAll(ricoID);
            var dd = RedisProvider.ConvertFromRedis<Users>(c);
            return View();
        }
        public static Dictionary<String, Object> parse(byte[] json)
        {
            string jsonStr = Encoding.UTF8.GetString(json);
            return JsonConvert.DeserializeObject<Dictionary<String, Object>>(jsonStr);
        }

        public object GetRedis()
        {

            string userjsonData = HttpContext.Session.GetString("userData");

            //反序列化成List<SelectListitem>集合物件
            var data = JsonConvert.DeserializeObject<User>(userjsonData);

            return data;
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