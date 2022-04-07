﻿using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Math.EC.Rfc7748;
using TuanBuy.Models;
using TuanBuy.Models.AppUtlity;
using TuanBuy.Models.Entities;
using TuanBuy.Models.Interface;
using TuanBuy.ViewModel;

namespace TuanBuy.Controllers
{
    //[Authorize(Roles = "User")]
    //[Authorize(Roles = "FullUser")]
    public class MemberCenterController : Controller
    {
        private readonly IRepository<User> _userRepository;
        private readonly TuanBuyContext _dbContext;
        public MemberCenterController(GenericRepository<User> userRepository,TuanBuyContext dbContext)
        {
            _userRepository = userRepository;
            _dbContext = dbContext;
        }
        
        //會員中心首頁
        public IActionResult Index()
        {
            return View();
        }
        //更改密碼頁面
        public IActionResult ResetPassword()
        {
            return View();
        }
        //我是買家我購買的商品
        public IActionResult MyBuyProduct()
        {
            return View();
        }

        //我是賣家我的商品
        public IActionResult MyProduct()
        {
            return View();
        }


        //接收傳遞過來的URL去解碼判斷啟用會員
        [AllowAnonymous]
        public IActionResult StartMemberState(string s)
        {
            Console.WriteLine(s);

            var decodeEmail = Models.AppUtlity.GoDecode.Decode(s);

            var targetUser = _userRepository.Get(x => x.Email == decodeEmail);
            if (_userRepository == null)
            {
                return BadRequest();
            }
            else
            {
                targetUser.State = UserState.普通會員.ToString();
                _userRepository.SaveChanges();
            }

            return RedirectToAction("Login", "Home");
        }

        #region 會員個人販賣商品頁面
        [HttpGet]
        public IActionResult MyStoreSell(int id)
        {
            return View();
        }
        #endregion

        #region 取得賣家商場資料
        [HttpGet]
        public SellerUser GetSellerData(int id)
        {
            var data = new MemberMange(_dbContext);
            var target =data.GetUerData(id);
            return target;
        }
        #endregion
    }
}
