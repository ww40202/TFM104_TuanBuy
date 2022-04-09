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
        //訂單管理join
        public List<OrderBackMangeViewModel> GetOrderDetails()
        {
            var orderdetails = from orderdetail in _dbContext.OrderDetail
                               join oder in _dbContext.Order on orderdetail.OrderId equals oder.Id
                               join product in _dbContext.Product on orderdetail.ProductId equals product.Id
                               join user in _dbContext.User on orderdetail.ProductId equals user.Id
                               //where orderdetail.Disable == false
                               select new OrderBackMangeViewModel()
                               {
                                   Address = oder.Address,
                                   Count = orderdetail.Count,
                                   CreateDate = oder.CreateDate,
                                   OrderId = orderdetail.OrderId,
                                   PaymentType = oder.PaymentType,
                                   Phone = oder.Phone,
                                   Price = orderdetail.Price,
                                   ProductName = product.Name,
                                   UserName = user.Name,
                               };
            var result = orderdetails.ToList();
            return result;
        }



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
    }
}
