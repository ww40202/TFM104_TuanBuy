
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TuanBuy.Models.Entities
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Key]
        public int Id { get; set; }
        public int? Count { get; set; }
        public decimal? Price { get; set; }
        public bool Disable { get; set; } = false;


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        //[ForeignKey("Order")]
        //public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }

}
