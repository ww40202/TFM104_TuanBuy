using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TuanBuy.Models;
using TuanBuy.Models.Entities;
using TuanBuy.ViewModel;

namespace TuanBuy.Controllers
{
    public class MemberController : Controller
    {
        //自訂建構子 同時注入一個組態物件
        private IConfiguration _config;
        private SqlDbServices _sqldb;
        public MemberController(IConfiguration configuration, SqlDbServices sqlDbServices)
        {
            _config = configuration;
            _sqldb = sqlDbServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        //聊天室 需要登入才可進入
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public IActionResult chatRoom()
        {
            return View();
        }

        #region 取得存在放Session的目前使用者
        public User GetOnlineMember()
        {
            string userjsonData = HttpContext.Session.GetString("userData");
            if (!String.IsNullOrEmpty(userjsonData))
            {
                //反序列化成List<SelectListitem>集合物件
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(userjsonData);
                return data;
            }
            return null;
        }
        #endregion

        #region 取得聊天室好友清單
        public List<ChatRoomListViewModel> getChatRoomUser()
        {
            UserDb db = new UserDb(_sqldb);
            string userjsonData = HttpContext.Session.GetString("userData");
            if (!String.IsNullOrEmpty(userjsonData))
            {
                //反序列化成List<SelectListitem>集合物件
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(userjsonData);
                //抓取該會員聊天室資料
                //List<ChatRoom> ChatData = db.GetChatUser(data.UserAccount);
                //TODO
                List<ChatRoomListViewModel> result = db.GetChatUserList(data.Id);
                return result;
            }
            return null;
        }
        #endregion

        #region 新增聊天室訊息
        public string CreateMessage(int MemberId, Guid ChatRoomId, string Message)
        {
            UserDb db = new UserDb(_sqldb);
            try
            {
                db.CreateMessage(MemberId, ChatRoomId, Message);
                return "OK";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return "Error";
        }

        #endregion

        #region 取得聊天室訊息
        public object GetChatMessage(string chatRoomId)
        {
            string userjsonData = HttpContext.Session.GetString("userData");
            if (chatRoomId != null)
            {
                //反序列化成List<SelectListitem>集合物件
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(userjsonData);
                UserDb db = new UserDb(_sqldb);
                var result = db.GetChatMessage(Guid.Parse(chatRoomId), data.Id);
                return result;
            }
            return null;
        }

        #endregion
    }
}
