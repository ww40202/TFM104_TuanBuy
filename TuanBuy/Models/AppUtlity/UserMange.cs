using TuanBuy.Models.Entities;
using TuanBuy.ViewModel;

namespace TuanBuy.Models.AppUtlity
{
    public class UserMange
    {
        private TuanBuyContext _dbContext;
        public UserMange(TuanBuyContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool CreateOAuthUser(User user)
        {
            user.State = UserState.普通會員.ToString();
            _dbContext.User.Add(user);
            _dbContext.SaveChanges();
            return true;
        }
    }
}