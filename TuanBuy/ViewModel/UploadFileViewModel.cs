using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace TuanBuy.ViewModel
{
    public class UploadFileViewModel
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<IFormFile> Pic { get; set; }
    }
}