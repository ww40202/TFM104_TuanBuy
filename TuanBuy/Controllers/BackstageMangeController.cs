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
        // GET: BackstageMangeController
        public ActionResult Index()
        {
            return View();
        }

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



        // GET: BackstageMangeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BackstageMangeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BackstageMangeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BackstageMangeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        //訂單管理
        public IActionResult Order()
        {
            return View();
        }
        [HttpGet]
        public List<OrderBackMangeViewModel> TestJoin()
        {
            var BackOrder = new OrderManage(_dbcontext);
            var result = BackOrder.get();
            return result;
        }
        [HttpPut]
        public IActionResult UpdateOrder([FromBody] int id, OrderDetail order)
        {

            var orders = _dbcontext.OrderDetail.FirstOrDefault(x => x.Id == id);
            if (orders != null)
            {
                orders.Address = order.Address;
                orders.Phone = order.Phone;
            }
            _dbcontext.SaveChanges();
            return Ok();
            //var targetOrder = _dbcontext.OrderDetail.FirstOrDefault(x => x.Id == order.Id);
            //if (targetOrder == null) return BadRequest();
            //targetOrder.Address = order.Address;
            //targetOrder.Phone = order.Phone;
            //_dbcontext.SaveChanges();
            //return Ok();
        }
        //刪除訂單
        //[HttpDelete]
        //public IActionResult DeleteOrder(string id)
        //{

        //    var user = _dbcontext.OrderDetail.FirstOrDefault(x => x.Id == id);
        //    if (user == null) return BadRequest();
        //    user.Disable = true;
        //    _dbcontext.SaveChanges();
        //    return Ok();
        //}

        //public  List<OrderBackMangeViewModel> GetOrder()
        //{
        //    var order=_dbcontext.OrderDetail.ToList();
        //    return (order);
        //}

    }
}
