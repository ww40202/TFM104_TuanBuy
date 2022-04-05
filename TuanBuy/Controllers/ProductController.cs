using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TuanBuy.Models;
using TuanBuy.Models.Entities;
using TuanBuy.Models.Interface;
using TuanBuy.ViewModel;

namespace TuanBuy.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository<Product> _productsRepository;
        private readonly IWebHostEnvironment _environment;
        private readonly IRepository<User> _userRepository;
        private readonly TuanBuyContext _dbContext;
        public ProductController(GenericRepository<Product> productsRepository, IWebHostEnvironment environment, GenericRepository<User> userRepository, TuanBuyContext dbContext)
        {
            _productsRepository = productsRepository;
            _environment = environment;
            _userRepository = userRepository;
            _dbContext = dbContext;
        }
        //新增商品首頁
        [Authorize(Roles = "FullUser")]
        public IActionResult Index()
        {
            return View();
        }
        //新增商品頁
        public IActionResult Test()
        {
            return View();
        }

        //商品介紹頁
        public IActionResult DemoProduct()
        {
            return View();
        }
        //商品介紹頁
        [HttpGet]
        public IActionResult DemoProduct(int id)
        {
            ProductManage product = new ProductManage(_dbContext);
            var result = product.GetDemoProductData(id);
            return View(result);
        }

        #region 取得商品頁資料
        [HttpGet]
        public DemoProductViewModel GetProductData(int id)
        {
            ProductManage product = new ProductManage(_dbContext);
            var result = product.GetDemoProductData(id);
            return result;
        }
        #endregion

        #region 取得商品頁留言
        [HttpGet]
        public List<ProductMessageViewModel> GetProductMessage(int id)
        {
            ProductManage product = new ProductManage(_dbContext);
            var result = product.GetProductMessageData(id);
            return result;
        }
        [HttpPost]
        #endregion 新增商品頁留言
        public IActionResult AddProductMessage(int ProductId,int UserId,string MessageContent)
        {
            ProductManage product = new ProductManage(_dbContext);              
            //新增商品頁留言
            product.AddProductMessage(ProductId,UserId,MessageContent);
            return Ok();
        }
        #region 
        #endregion

        //等待開團商品頁
        [Authorize(Roles = "FullUser")]
        public IActionResult WaitingProduct()
        {
            return View();
        }
        //已開團商品頁
        [Authorize(Roles = "FullUser")]
        public IActionResult ReadyProduct()
        {
            return View();
        }
        //新增商品
        [HttpPost]
        [Authorize(Roles = "FullUser")]
        public IActionResult PostProduct(AddProductViewModel product)
        {
            if (product.PicPath == null)
            {
                return BadRequest();
            }


            var targetUser = GetTargetUser();

            #region 建立商品
            var targetProduct = new Product
            {
                Name = product.Name,
                Content = product.Content,
                Category = product.Category,
                Description = product.Description,
                CreateTime = DateTime.Now,
                EndTime = product.EndTime,
                Price = product.Price,
                User = targetUser
            };
            _productsRepository.Create(targetProduct);
            _productsRepository.SaveChanges();
            #endregion

            //檔案路徑
            var path = _environment.WebRootPath + "/ProductPicture";

            #region 加入圖片
            
            
            foreach (var file in product.PicPath)
            {
                if (file != null)
                {
                    var fileName = DateTime.Now.Ticks + file.FileName;
                    using var fs = System.IO.File.Create($"{path}/{fileName}");
                    file.CopyTo(fs);
                    var pPic = new ProductPic()
                    {
                        Product = targetProduct,
                        PicPath = fileName
                    };
                    _dbContext.ProductPics.Add(pPic);
                }
            }
            _dbContext.SaveChanges();


            #endregion
            return Ok();
        }


        [Authorize(Roles = "FullUser")]
        public IActionResult MyProduct()
        {
            return View();
        }
        //抓取當前使用者
        private User GetTargetUser()
        {
            var claim = HttpContext.User.Claims;
            var userEmail = claim.FirstOrDefault(a => a.Type == ClaimTypes.Email)?.Value;
            var targetUser = _userRepository.Get(a => a.Email == userEmail);
            return targetUser;
        }
    }
}
