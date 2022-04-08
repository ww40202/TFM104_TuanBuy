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



        #region 取得購買的訂單

        //取得購買的訂單
        public List<OrderViewModel> GetMyOrder(int id)
        {
            var orders =
                from order in _dbContext.Order
                where order.UserId == id
                join orderDetail in _dbContext.OrderDetail on order.Id equals orderDetail.OrderId
                join product in _dbContext.Product on orderDetail.ProductId equals product.Id
                join seller in _dbContext.User on product.UserId equals seller.Id
                select new OrderViewModel()
                {
                    OrderId = order.Id,
                    OrderState = order.StateId,
                    Description = order.Description,
                    Count = orderDetail.Count,
                    PaymentType = order.PaymentType,
                    Address = order.Address,
                    SellerId = seller.Id,
                    SellerName = seller.Name
                };
            var result = orders.ToList();


            return result;
        }

        #endregion


    }
}
