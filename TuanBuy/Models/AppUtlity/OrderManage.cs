using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuanBuy.ViewModel;

namespace TuanBuy.Models.Entities
{
    public class OrderManage
    {
        private readonly TuanBuyContext _dbContext;
        public OrderManage(TuanBuyContext context)
        {
            _dbContext = context;
        }
        //public List<OrderBackMangeViewModel> get()
        //{
        //var result = from o in _dbcontext.OrderDetail
        //             join p in _dbcontext.Product on o.Id equals p.Id
        //             join i in _dbcontext.Order on o.Id equals i.Id
        //             join y in _dbcontext.User on o.Id equals y.Id
        //             select new OrderBackMangeViewModel
        //             {
        //                 Address = o.Address,
        //                 Count = o.Count,
        //                 CreateDate = i.CreateDate,
        //                 Phone = y.Phone,
        //                 OrderId = o.Id,
        //                 PaymentType = o.PaymentType,
        //                 ProductName = p.Name,
        //                 Total = o.Total,
        //                 UserName = y.Name
        //             };
        //var result = from o in _dbcontext.OrderDetail
        //join p in _dbcontext.Product on o.Id equals p.Id
        //join i in _dbcontext.Order on o.Id equals i.Id
        //join y in _dbcontext.User on i.User.Id equals y.Id
        //select new OrderBackMangeViewModel
        //{
        //Address = o.Address,
        //Count = o.Count,
        //CreateDate = i.CreateDate,
        //Phone = y.Phone,
        //OrderId = o.Id,
        ////PaymentType = o.PaymentType,
        //ProductName = p.Name,
        //Price=p.Price,
        //UserName=i.User.Name
        //};
        //var test = result.ToList();
        //return test;

        //}





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
                    myOrderDetail.ProductPath = "/productpicture/" +item.pic.PicPath;
                }
                myOrderDetails.Add(myOrderDetail);
            }
            return myOrderDetails;
        }
    }
}
