using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuanBuy.ViewModel;

namespace TuanBuy.Models.Entities
{
    public class ProductManage
    {
        private TuanBuyContext _dbContext;
        public ProductManage(TuanBuyContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region 取得商品頁資料
        public DemoProductViewModel GetDemoProductData(int ProductId)
        {
            //群組join
            var result = _dbContext.Product.ToList().GroupJoin(
                    _dbContext.ProductPics.ToList(),
                    prd => prd.Id,
                    pit => pit.ProductId,
                    (product,productimg)=> new {product}                
                ).ToList().Where(x=>x.product.Id==ProductId).GroupJoin(_dbContext.User,
                    prd => prd.product.UserId,
                    user => user.Id,
                    (prd,user) => new { prd}
                ).ToList().GroupJoin(_dbContext.Order,
                    user => user.prd.product.Id,
                    order=> order.ProductId,
                    (user,order) => new {user}                
                );
            DemoProductViewModel demoProductViewModel = new DemoProductViewModel();
            List<string> productPicPath = new List<string>();
            foreach (var item in result)
            {
                demoProductViewModel.Id = item.user.prd.product.Id;
                demoProductViewModel.ProductTitle = item.user.prd.product.Name;
                demoProductViewModel.ProductSummary = item.user.prd.product.Content;
                demoProductViewModel.ProductCategory = item.user.prd.product.Category;
                demoProductViewModel.ProductDescription = item.user.prd.product.Description;
                demoProductViewModel.ProductTargetPrice = item.user.prd.product.Price;
                demoProductViewModel.ProductStartTime = item.user.prd.product.CreateTime;
                demoProductViewModel.ProductEndTime = item.user.prd.product.EndTime;
                //開團日期及結束日期差計算
                TimeSpan timeSpan = item.user.prd.product.EndTime.Subtract(item.user.prd.product.CreateTime).Duration();
                demoProductViewModel.ProductLastTime = timeSpan.Days.ToString() + "天" + timeSpan.Hours.ToString() + "小時" + timeSpan.Minutes.ToString() + "分鐘";
                //賣家開團主相關資訊
                demoProductViewModel.SellerId = item.user.prd.product.User.Id;
                demoProductViewModel.Seller = item.user.prd.product.User.NickName;
                //目前團購已訂購人數

                if(item.user.prd.product.Order !=null)
                {
                    demoProductViewModel.Buyers = item.user.prd.product.Order.Count.ToString();
                }
                if (item.user.prd.product.ProductPics != null)
                {
                    foreach (var picpath in item.user.prd.product.ProductPics)
                    {
                        productPicPath.Add($"/ProductPicture/{picpath.PicPath}");
                    }
                }
                demoProductViewModel.ProductPicPath = productPicPath;
            }
            return demoProductViewModel;
        }
        #endregion

        #region 取得商品頁留言
        public List<ProductMessageViewModel> GetProductMessageData(int ProductId)
        {
            //取得商品頁留言訊息
            var message = (from productmessage in _dbContext.ProductMessages
                          join user in _dbContext.User on productmessage.UserId equals user.Id
                         where productmessage.ProductId == ProductId
                         select new { productmessage ,user}).ToList().OrderByDescending(x=>x.productmessage.Id);
            //取得賣家回覆訊息
            var sellerReplies = from seller in _dbContext.ProductSellerReplies
                                join user in _dbContext.User on seller.UserId equals user.Id
                                where (message.Select(x => x.productmessage.Id).Contains(seller.ProductMessageId))
                                select new { seller,user};
            //var result = from message in _dbContext.ProductMessages select message;
            List<ProductMessageViewModel> productMessageViewModels = new List<ProductMessageViewModel>();
            //先分裝買家留言訊息 裡面判斷賣家是否有回覆訊息
            foreach (var item in message)
            {
                ProductMessageViewModel productMessage = new ProductMessageViewModel();
                productMessage.MessagePicPaht = item.user.PicPath;
                productMessage.MessageName = item.user.NickName;
                productMessage.MessageContent = item.productmessage.MessageContent;
                productMessage.MessageDateTime = item.productmessage.CreatedDate;
                productMessage.MessageId = item.productmessage.Id;
                //賣家回覆訊息
                foreach(var sellerReply in sellerReplies)
                {
                    if (sellerReply.seller.ProductMessageId == item.productmessage.Id)
                    {
                        productMessage.SellerReply = sellerReply.seller.MessageContent;
                        productMessage.SellerName = sellerReply.user.NickName;
                        productMessage.ReplyDateTime = sellerReply.seller.CreatedDate;
                    }
                }
                productMessageViewModels.Add(productMessage);
            }


            return productMessageViewModels;
        }
        #endregion

        #region 新增商品頁留言 
        public void AddProductMessage(int ProductId, int UserId, string MessageContent)
        {
                using(_dbContext)
                { 
                    ProductMessage productMessage = new ProductMessage();
                    productMessage.ProductId = ProductId;
                    productMessage.UserId = UserId;
                    productMessage.MessageContent = MessageContent;
                    productMessage.CreatedDate = DateTime.Now;
                    _dbContext.ProductMessages.Add(productMessage);
                    _dbContext.SaveChanges();
                }
        }
        #endregion

        #region 賣家回覆商品頁留言
        public void AddSellerMessage(int ProductMessageId, int SellerId, string MessageContent)
        {
            using(_dbContext)
            {
                ProductSellerReply productSellerReply = new ProductSellerReply();
                productSellerReply.UserId = SellerId;
                productSellerReply.CreatedDate = DateTime.Now;
                productSellerReply.MessageContent = MessageContent;
                productSellerReply.ProductMessageId = ProductMessageId;
                _dbContext.ProductSellerReplies.Add(productSellerReply);
                _dbContext.SaveChanges();
            }
        }
        #endregion
    }
}
