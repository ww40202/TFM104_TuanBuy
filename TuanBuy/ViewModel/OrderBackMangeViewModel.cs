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
        public string Category { get; set; }
        public string CreateTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public decimal Total { get; set; }
        public string UserName { get; set; }
        public bool Disable { get; set; }
    }
    //首頁資訊
    public class HomeBackMangeViewModel
    {
        public int UserCount { get; set; }
        public int ProductCount { get; set; }
        //處理中訂單  已完成訂單
        public int ProcessOrder { set; get; }
        public int FinishOrder { get; set; }
        public int TotalSales { get; set; }
        public string Hotproduct { get; set; }
    }
}
