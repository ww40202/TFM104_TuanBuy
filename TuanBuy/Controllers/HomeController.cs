using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using TuanBuy.Models;
using TuanBuy.Models.AppUtlity;
using TuanBuy.Models.Bank.Extensions;
using TuanBuy.Models.Entities;
using TuanBuy.Service;
using TuanBuy.ViewModel;

namespace TuanBuy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TuanBuyContext _dbContext;
        public HomeController(ILogger<HomeController> logger, TuanBuyContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        //首頁
        public IActionResult Index()
        {
            return View();
        }
        //登入畫面
        public IActionResult Login()
        {
            return View();
        }
        //註冊畫面
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ForgetPassword()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult FbLogin()
        {
            var p = new AuthenticationProperties()
            {
                RedirectUri = Url.Action("Response")
            };
            return Challenge(p, FacebookDefaults.AuthenticationScheme);
        }

        public IActionResult GoogleLogin()
        {
            var p = new AuthenticationProperties()
            {
                RedirectUri = Url.Action("Response")
            };
            return Challenge(p, GoogleDefaults.AuthenticationScheme);
        }


        public async Task<IActionResult> ResponseAsync()
        {
            var res = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            if (res.Principal == null) return BadRequest();

            var data = res.Principal.Claims.Select(x => new
            {
                x.Type,
                x.Issuer,
                x.Value,
                x.OriginalIssuer
            });

            var test =
                res.Principal.Claims.Select(x => new KeyValuePair<string, string>(x.Type, x.Value)).ToList();

            test.GetValueByKey("emailaddress");
            test.GetValueByKey("name");



            #region 建立User
            var user = new User();
            foreach (var item in data)
            {
                var types = item.Type.Split("/");
                var type = types[^1];

                if (type == "emailaddress")
                {
                    var targetUser = _dbContext.User.FirstOrDefault(u => u.Email == item.Value);
                    user.Email = item.Value;
                    if (targetUser != null)
                    {
                        var claims = new List<Claim>
                        {
                            new(ClaimTypes.Name, user.NickName),
                            new(ClaimTypes.Email, user.Email),
                            new("Userid", user.Id.ToString()),
                            new("NickName", user.NickName),
                            new("Email", user.Email),
                            new("UserName", user.Name),
                            new("PicPath",user.PicPath),
                        };
                        //將使用者資訊存入
                        //
                        var jsonstring = JsonConvert.SerializeObject(new
                        {
                            user.Email,
                            user.NickName,
                            user.Id,
                            user.PicPath
                        });
                        HttpContext.Session.SetString("userData", jsonstring);
                        if (user.State == "普通會員") claims.Add(new Claim(ClaimTypes.Role, "User"));
                        if (user.State == "正式會員") claims.Add(new Claim(ClaimTypes.Role, "FullUser"));

                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);


                        return View("Index");
                    }
                }
                else
                {
                    switch (type)
                    {
                        case "name":
                            user.Name = item.Value;
                            break;
                        //case "emailaddress":
                        //    user.Email = item.Value;
                        //    break;
                        case "nameidentifier":
                            user.Password = GoEncrytion.encrytion(item.Value);
                            break;
                    }
                }
            }
            var userMange = new UserMange(_dbContext);
            userMange.CreateOAuthUser(user);
            #endregion


            return View("Index");
        }


    }
}

