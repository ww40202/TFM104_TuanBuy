using System;
using System.Collections;
using System.Collections.Generic;
using TuanBuy.Models.Entities;

namespace TuanBuy.ViewModel
{
    public class OrderViewModel
    {
        //訂單ID
        public int OrderId { get; set; }
        //訂單備註
        public string Description { get; set; }
        //商品ID
        public int ProductId { get; set; }
        //商品圖片
        public string ProductPath { get; set; }
        //商品名稱
        public string ProductName { get; set; }
        //商品描述
        public string ProductDescription { get; set; }
        //商品單價
        public decimal ProductPrice { get; set; }
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