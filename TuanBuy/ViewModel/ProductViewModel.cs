using System;

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
        public string Category { get; set; }
        public string Href { get; set; } = "";

    }
}