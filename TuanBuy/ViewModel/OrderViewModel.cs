using System;

namespace TuanBuy.ViewModel
{
    public class OrderViewModel
    {
        //訂單ID
        public int OrderId { get; set; }
        //訂單備註
        public string Description { get; set; }
        //送貨地址
        public string Address { get; set; }
        //付款方式
        public int PaymentType { get; set; }
        //購買數量
        public int Count { get; set; }
        //賣家ID
        public int SellerId { get; set; }
        //賣家名稱
        public string SellerName { get; set; }
        //訂單狀態
        public int OrderState { get; set; }
    }
}