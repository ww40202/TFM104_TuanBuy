using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TuanBuy.Models.Entities
{
    [Table("Order")]
    public  class Order
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string State { get; set; } = "未付款";
        public DateTime CreateDate { get; set; }
        public bool Disable { get; set; } = false;
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        //[ForeignKey("User")]
        //public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
