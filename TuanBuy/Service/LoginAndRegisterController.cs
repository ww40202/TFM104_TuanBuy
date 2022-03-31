using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TuanBuy.Models;
using TuanBuy.Models.Entities;
using TuanBuy.Models.Interface;
using TuanBuy.ViewModel;

namespace TuanBuy.Service
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginAndRegisterController : Controller
    {
        private readonly IRepository<User> _userRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginAndRegisterController(GenericRepository<User> userRepository, IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("{email}")]
        //如果Email沒被使用過回傳1，不然回傳0
        public int Check(string email)
        {
            
            var user = _userRepository.Get(a => a.Email == email);
            if (user == null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        
        /// <summary>
        /// 取得UserData
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetUserData()
        {
            if (_httpContextAccessor.HttpContext != null)
            {
                var claim = _httpContextAccessor.HttpContext.User.Claims.ToList();
                if (claim.Count == 0)
                {
                    return "null";
                }
                var userName = claim.First(a => a.Type == "UserName").Value;
                //var userName = Claim.Where(a => a.Type == "UserName").First().Value;


                return userName;
            }
            else
            {
                return "null";
            }
        }

        [HttpPost]
        //登入順便給予權限
        public string Login(UserRegister loginUser)
        {
            var user = _userRepository.Get(a => a.Email == loginUser.Email && a.Password  ==loginUser.Password);
            if (user == null || user.Email == null || loginUser.Email == "" || loginUser.Password == "" )
            {
                return "帳號密碼錯誤";
            }

            if (user.State == 0)
            {
                return "帳號未啟用";
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.NickName),
                    new Claim(ClaimTypes.Email,user.Email),
                    new Claim("Userid",user.Id.ToString()),
                    new Claim("NickName",user.NickName),
                    new Claim("Email",user.Email.ToString()),
                    new Claim("UserName",user.Name.ToString())


                };
                //將使用者資訊存入session
                string jsonstring = Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    Email = user.Email,
                    NickName = user.NickName,
                    Id = user.Id
                });
                HttpContext.Session.SetString("userData", jsonstring);
                if (user.State >= 1)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "User"));
                }
                if (user.State == 2)
                {
                    claims.Add(new Claim(ClaimTypes.Role, "FullUser"));
                }
                
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                HttpContext.SignInAsync(claimsPrincipal);
                //HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return "登入成功";
            }
        }

        [HttpDelete]
        public void Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

    }
}
