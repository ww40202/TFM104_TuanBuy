using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TuanBuy.Models.Entities;
using TuanBuy.ViewModel;

namespace TuanBuy.Controllers
{
    public class BackstageMangeController : Controller
    {
        private readonly TuanBuyContext _dbcontext;
        public BackstageMangeController(TuanBuyContext context)
        {
            _dbcontext = context;
        }
        // 會員後台管理首頁
        public ActionResult Index()
        {
            return View();
        }
        #region 會員管理
        public List<UserBackMange> GetUsers()
        {
            var ableUsers = _dbcontext.User.Where(x => x.Disable == false);

            return ableUsers.Select(u => new UserBackMange
            {
                Name = u.Name,
                Email = u.Email,
                State = u.State,
                Birth = u.Birth,
                Phone = u.Phone
            }).ToList();
        }

        //更新使用者資料
        [HttpPut]
        public IActionResult UpdateUser([FromBody] UserBackMange user)
        {
            var targetUser = _dbcontext.User.FirstOrDefault(x => x.Email == user.Email);
            if (targetUser == null) return BadRequest();

            targetUser.Name = user.Name;
            targetUser.Birth = user.Birth;
            targetUser.State = user.State;
            targetUser.Phone = user.Phone;
            _dbcontext.SaveChanges();
            return Ok();
        }
        //軟刪除使用者
        [HttpDelete]
        public IActionResult DeleteUser(string id)
        {
            var user = _dbcontext.User.FirstOrDefault(x => x.Email == id);
            if (user == null) return BadRequest();
            user.Disable = true;
            _dbcontext.SaveChanges();
            return Ok();
        }
        #endregion


        public IActionResult Order()
        {
            return View();
        }
        //秀出OrderManage資訊
        public List<OrderBackMangeViewModel> TestJoin()
        {
            var BackOrder = new OrderManage(_dbcontext);
            var result = BackOrder.GetOrderDetails();
            return result;
        }
        //修改訂單
        [HttpPut]
        public IActionResult UpdateOrder([FromBody] OrderBackMangeViewModel order)
        {

            var orders = _dbcontext.Order.FirstOrDefault(x => x.Id == order.OrderId);
            if (orders == null) return BadRequest();
            orders.Address = order.Address;
            orders.Phone = order.Phone;
            _dbcontext.SaveChanges();
            return Ok();

        }
        //刪除訂單
        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            var user = _dbcontext.OrderDetail.FirstOrDefault(x => x.OrderId == id);
            if (user == null) return BadRequest();
            //user = user.Select(x => new OrderDetail() { Disable = true });
            user.Disable = true;
            _dbcontext.SaveChanges();
            return Ok();
        }
        //查詢
        //public IActionResult inquireOrder(int id)
        //{
        //    var order = _dbcontext.OrderDetail.Select(x => x.OrderId).Distinct();
        //    var numbering = from c in _dbcontext.OrderDetail
        //                    where c.OrderId == id
        //                    select c;

        //}

        //產品管理撈出上架商品
        public List<ProductBackMangeViewModel> ProductJoin()
        {
            var BackOrder = new OrderManage(_dbcontext);
            var result = BackOrder.GetProduct();
            return result;
        }

        //產品下架
        [HttpDelete]
        public IActionResult ProductDown(int id)
        {
            var user = _dbcontext.Product.FirstOrDefault(x=>x.Id==id);
            if (user == null) return BadRequest();
            //user = user.Select(x => new OrderDetail() { Disable = true });
            user.Disable = true;
            _dbcontext.SaveChanges();
            return Ok();
        }
        ////產品管理撈出下架商品
        //public List<ProductBackMangeViewModel> ProductJoinup()
        //{
        //    var BackOrder = new OrderManage(_dbcontext);
        //    var result = BackOrder.GetProductdown();
        //    return result;
        //}
        //產品上架
        [HttpDelete]
        public IActionResult ProductUp(int id)
        {
            var user = _dbcontext.Product.FirstOrDefault(x => x.Id == id);
            if (user == null) return BadRequest();
            //user = user.Select(x => new OrderDetail() { Disable = true });
            user.Disable = false;
            _dbcontext.SaveChanges();
            return Ok();
        }
    }
}
