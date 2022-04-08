
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TuanBuy.Models.Entities
{
    public class OrderDetail
    {
        //商品數量
        public int Count { get; set; }
        //商品單價
        public decimal Price { get; set; }
        //商品軟刪除
        public bool Disable { get; set; } = false;
        //關連到商品ID
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        //關連到訂單ID
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        
    }

}
