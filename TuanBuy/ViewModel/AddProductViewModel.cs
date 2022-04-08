using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace TuanBuy.ViewModel
{
    public class AddProductViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public string Description { get; set; }
        public List<IFormFile> PicPath { get; set; }

        public DateTime EndTime { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
    }
}
