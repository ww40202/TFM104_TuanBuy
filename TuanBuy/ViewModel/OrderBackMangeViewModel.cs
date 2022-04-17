using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuanBuy.Models.Entities;

namespace TuanBuy.ViewModel
{
    //訂單管理
    public class OrderBackMangeViewModel
    {
        public string OrderId { get; set; }
        public string UserName { get; set; }
        public string CreateDate { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? PaymentType { get; set; }
        public decimal Price { get; set; }
        public bool Disable { get; set; } = false;
    }
    //商品管理
    public class ProductBackMangeViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public string PicPath { get; set; }

        public bool Disable { get; set; }
    }
    public class ProductBackMangeViewMode2
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public string PicPath { get; set; }
    }
}
