using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TuanBuy.Models.Entities;
using TuanBuy.ViewModel;

namespace TuanBuy.Controllers
{
    public class DemoController
    {
        private readonly TuanBuyContext _dbContext;
        public DemoController(TuanBuyContext context)
        {
            _dbContext = context;
        }


        public List<OrderViewModel> GetMyOrder(int userId)
        {
            var orders = 
                from order in _dbContext.Order
                where order.UserId == userId 
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