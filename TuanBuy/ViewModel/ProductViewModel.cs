using System;
using System.Collections.Generic;
using System.Linq;
using TuanBuy.Models.Entities;

namespace TuanBuy.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string PicPath { get; set; }
        public decimal Price { get; set; }
        public decimal TargetPrice { get; set; }
        public decimal? Total { get; set; }
        public string Category { get; set; }
        public string Href { get; set; } = "";
        public User User { get; set; }
        public int UserId { get; set; }
        public bool Disable { get; set; }
        public string LastTime { get; set; }
        public string Percentage { get; set; }
        public string Color { get; set; }
    }

    public class DemoProductViewModel
    {
        //該產品Id
        public int Id { get; set; }
        //團主名稱
        public string Seller { get; set; }
        //團主會員ID
        public int SellerId { get; set; }
        //商品品名
        public string ProductTitle { get; set; }
        //商品種類
        public string ProductCategory { get; set; }
        //商品詳細敘述
        public string ProductDescription { get; set; }
        //商品簡述
        public string ProductSummary { get; set; }
        //產品目標金額
        public decimal ProductTargetPrice { get; set; }
        //產品開團時間
        public DateTime ProductStartTime { get; set; }
        //開團結束時間
        public DateTime ProductEndTime { get; set; }
        //產品剩餘天數
        public string ProductLastTime { get; set; }
        //加入團購人數
        public string Buyers { get; set; }
        //產品圖片
        public List<string> ProductPicPath { get; set; }
    }
    public class ProductMessageViewModel
    {
        //留言id
        public int MessageId { get; set; }
        //留言者頭像
        public string MessagePicPaht { get; set; }
        //留言者名稱
        public string MessageName { get; set; }
        //留言時間
        public DateTime MessageDateTime { get; set; }
        //留言者內容
        public string MessageContent { get; set; }

        //賣家名稱
        public string SellerName { get; set; }
        //賣家回覆訊息
        public string SellerReply { get; set; }
        //賣家回覆訊息時間
        public DateTime ReplyDateTime { get; set; }
    }
    public class ProductCheckViewModel
    {
        //產品的名稱
        public int ProductId { get; set; }
        //產品圖片
        public string ProductPicPath { get; set; }
        //產品敘述
        public string ProductDescription { get; set; }
        //產品單價
        public decimal ProductPrice { get; set; }
        //買家Id
        public int BuyerId { get; set; }
        //買家姓名
        public string BuyerName { get; set; }
        //買家電話
        public string BuyerPhone { get; set; }
        //買家宅配地點
        public string BuyerAddress { get; set; }
    }

}