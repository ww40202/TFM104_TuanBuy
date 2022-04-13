using System;

namespace TuanBuy.ViewModel
{
    public class UserViewModel
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string BankAccount { get; set; }
        public DateTime? Birth { get; set; }
        public int Sex { get; set; }
        public string Address { get; set; }
        public string PicPath { get; set; }
    }

    public class SellerUser
    {
        public string Name { get; set; }
        public string PicPath { get; set; }
    }
    public class UserBackMange
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public DateTime? Birth { get; set; }

    }
    public enum UserState
    {
        未驗證,
        普通會員,
        正式會員,
        系統管理員
    }

    public class UserData
    {
        public string Email { get; set; }
        public string NickName { get; set; }
        public int Id { get; set; }
        public string PicPath { get; set; }
    }
}
