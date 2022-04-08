using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuanBuy.ViewModel;

namespace TuanBuy.Models.Entities
{
    public class OrderManage
    {
        private readonly TuanBuyContext _dbcontext;
        public OrderManage(TuanBuyContext context)
        {
            _dbcontext = context;
        }
        public List<OrderBackMangeViewModel> get()
        {
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
            var result = from o in _dbcontext.OrderDetail
                         join p in _dbcontext.Product on o.Id equals p.Id
                         //join i in _dbcontext.Order on o.Id equals i.Id
                         //join u in _dbcontext.User on i.User.Id equals u.Id
                         select new OrderBackMangeViewModel
                         {
                             
                             Address = o.Address,
                             Count = o.Count,
                             //CreateDate = i.CreateDate,
                             Phone = o.Phone,
                             OrderId = o.Id,
                             PaymentType = o.PaymentType,
                             ProductName = p.Name,
                             Price = p.Price,
                             //UserName = i.User.Name

                         }; 
           
                        var test = result.ToList();
                        return test;
            
            
                       

        }

    }
}
