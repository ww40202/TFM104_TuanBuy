using System.ComponentModel.DataAnnotations.Schema;

namespace TuanBuy.Models.Entities
{
    public class ShoppingProducts
    {
        //關連到商品ID
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        //關連到UserID
        [ForeignKey("ShoppingCarId")]
        public int ShoppingCarId { get; set; }
        public virtual ShoppingCar ShoppingCar { get; set; }
    }
}