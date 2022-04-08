
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
        public string Description { get; set; }
        public string Address { get; set; }
        public int? PaymentType { get; set; }
        public int? Count { get; set; }
        public decimal? Total { get; set; }
        public bool Disable { get; set; } = false;
        public string Phone { get; set; }
        public virtual Order Order { get; set; }         
        public virtual Product Product { get; set; }
        
    }

}
