﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data.Common;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TuanBuy.Models;
using TuanBuy.Models.Entities;
using TuanBuy.Models.Interface;
using TuanBuy.ViewModel;

namespace TuanBuy.Service
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IRepository<Product> _productsRepository;
        private readonly IRepository<User> _userRepository;
        private readonly TuanBuyContext _dbContext;
        public ProductsController(GenericRepository<Product> productsRepository, IWebHostEnvironment environment,
            GenericRepository<User> userRepository, TuanBuyContext dbContext)
        {
            _productsRepository = productsRepository;
            _environment = environment;
            _userRepository = userRepository;
            _dbContext = dbContext;
        }

        //我的商品
        [Route("MyProducts")]
        [HttpGet]
        public ActionResult<IEnumerable<ProductViewModel>> GetMyProducts()
        {
            var targetUser = GetTargetUser();

            var product = GetAllProducts();
            //只取第一張圖片
            var products = new List<ProductViewModel>();
            foreach (var p in product)
            {
                if (p.User == targetUser && p.Disable == false)
                {
                    var prod = new ProductViewModel
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Description = p.Description,
                        Content = p.Content,
                        Category = p.Category,
                        PicPath = p.PicPath,
                        EndTime = p.EndTime,
                        Price = p.Price,
                        Href = p.Href
                    };
                    products.Add(prod);
                }
            }

            return products;

        }



        //首頁撈商品
        [HttpGet]
        public ActionResult<IEnumerable<ProductViewModel>> GetProducts()
        {
            #region 原始版本 可以的
            //var products = GetAllProducts();
            //var result = products.Where(p => p.Disable == false)
            //    .Select(p => new ProductViewModel
            //    {
            //        Id = p.Id,
            //        Name = p.Name,
            //        Description = p.Description,
            //        Content = p.Content,
            //        Category = p.Category,
            //        PicPath = p.PicPath,
            //        EndTime = p.EndTime,
            //        Price = p.Price,
            //        Href = p.Href
            //    })
            //    .OrderByDescending(x => x.Id)
            //    .ToList();
            //return result;
            #endregion

            #region 測試
            //var result =
            //    from p in _dbContext.Product
            //    join pic in _dbContext.ProductPics on p.Id equals pic.Id //into prodPic
            //    join o in _dbContext.Order on p.Id equals o.Id
            //    join od in _dbContext.OrderDetail on o.Id equals od.Id
            //    where p.Disable == false
            //    orderby p.Id
            //    select new ProductViewModel
            //    {
            //        Id = p.Id,
            //        Total = p.Price * od.Count,
            //        Price = p.Price,
            //        Description = p.Description,
            //        Content = p.Content,
            //        Category = p.Category,
            //        PicPath = "/productpicture/" + pic.PicPath,
            //        EndTime = p.EndTime,
            //        Href = "/Product/DemoProduct/" + p.Id
            //    };
            //var test = result.ToList();

            //var result = (from product in _dbContext.Product
            //    join prdpics in _dbContext.ProductPics on product.Id equals prdpics.ProductId
            //    select new {product, prdpics}).ToList();


            #endregion
            var result = GetAllProducts();
            var result123 =
                (from orderdetail in _dbContext.OrderDetail
                where (result.Select(X => X.Id)).Contains(orderdetail.ProductId)
                select new {orderdetail}).ToList();
            var abc = new List<ProductViewModel>();
            foreach (var p in result)
            {
                var i = new ProductViewModel();
                    i.Id = p.Id;
                    i.Name = p.Name;
                    i.Description = p.Description;
                    i.Content = p.Content;
                    i.Category = p.Category;
                    i.PicPath = p.PicPath;
                    i.EndTime = p.EndTime;
                    i.Price = p.Price;
                    i.Total = 0;
                    i.Href = p.Href;
                    foreach (var orderDetils in result123)
                    {
                        if (orderDetils.orderdetail.ProductId == p.Id)
                        {
                            i.Total += orderDetils.orderdetail.Count * p.Price;
                        }
                    }
                    abc.Add(i);
            }

            return abc;


            //return test;
        }


        //修改商品
        [HttpPut]
        public IActionResult PutProduct([FromBody] UpDateProductViewModel product)
        {
            var p = _productsRepository.Get(a => a.Id == Convert.ToInt32(product.Id));
            p.Price = product.Price;
            p.Content = product.Content;
            p.Description = product.Description;
            p.EndTime = product.EndTime;
            _productsRepository.SaveChanges();

            return Ok();
        }



        //商品軟刪除
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _productsRepository.Get(p => p.Id == id);
            if (product == null) return NotFound();
            product.Disable = true;
            _productsRepository.SaveChanges();
            return NoContent();
        }

        private bool ProductExists(Product product)
        {
            var b = _productsRepository.Get(p => p == product);
            if (b == null) return true;

            return false;
        }

        //抓取當前User
        private User GetTargetUser()
        {
            var claim = HttpContext.User.Claims;
            var userEmail = claim.FirstOrDefault(a => a.Type == ClaimTypes.Email)?.Value;
            var targetUser = _userRepository.Get(a => a.Email == userEmail);
            return targetUser;
        }
        //抓取全部商品
        private List<ProductViewModel> GetAllProducts()
        {
            var product = _dbContext.Product.ToList().GroupJoin(
                _dbContext.ProductPics.ToList(),
                product => product,
                productPic => productPic.Product,
                (p, pic) => new ProductViewModel
                {
                    User = p.User,
                    Disable = p.Disable,
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Content = p.Content,
                    Category = p.Category,
                    PicPath = "/productpicture/" + pic.FirstOrDefault()?.PicPath,
                    EndTime = p.EndTime,
                    Price = p.Price,
                    Total = p.Total,
                    Href = "/Product/DemoProduct/" + p.Id
                }
            ).ToList();
            return product;
        }

    }
}