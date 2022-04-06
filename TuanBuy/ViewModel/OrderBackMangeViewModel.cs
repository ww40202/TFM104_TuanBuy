using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuanBuy.Models.Entities;

namespace TuanBuy.ViewModel
{
    public class OrderBackMangeViewModel
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public string ProductName { get; set; }
        public int? Count { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? PaymentType { get; set; }
        public decimal Price { get; set; }
    }
}
