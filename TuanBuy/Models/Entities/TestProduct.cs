using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuanBuy.Models.Entities
{
    public class TestProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }
        public string  PicPath { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}