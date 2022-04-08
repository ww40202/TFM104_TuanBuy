using System;
using System.ComponentModel.DataAnnotations;
using TuanBuy.Models.Entities;

namespace TuanBuy.ViewModel
{
    public class UpDateProductViewModel
    {
        public int Id { get; set; }
        public DateTime EndTime { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

    }
}