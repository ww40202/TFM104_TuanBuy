using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TuanBuy.Models.Entities
{
    public partial class TuanBuyContext : DbContext
    {

        public TuanBuyContext(DbContextOptions<TuanBuyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<User> User { get; set; }

        public virtual DbSet<ProductMessage> ProductMessages { get; set; }

        public virtual DbSet<ProductPic> ProductPics { get; set; }
        public virtual DbSet<ChatRoom> ChatRooms { get; set; }

        public virtual DbSet<ChatRoomMember> Member_Chats { get; set; }

        public virtual DbSet<ChatMessages> ChatMessages { get; set; }

        public virtual DbSet<ProductSellerReply> ProductSellerReplies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatRoomMember>().ToTable("Member_Chats");
            modelBuilder.Entity<ChatRoomMember>().HasKey(s => new { s.MemberId, s.ChatRoomId });
            
            modelBuilder.Entity<OrderDetail>().HasKey(s => new { s.ProductId, s.OrderId });
            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(pt => pt.OrderId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(pd => pd.Product)
                .WithMany(pd => pd.OrderDetails)
                .HasForeignKey(pt => pt.ProductId)
                .OnDelete(DeleteBehavior.ClientNoAction);


            //假資料
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                Email = "123@gmail.com",
                Password = "123456",
                Name = "小王",
                NickName = "賣貓的小王",
                State = "正式會員"
            });
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 2,
                Email = "456@gmail.com",
                Password = "123456",
                Name = "小明",
                NickName = "賣鮭魚的小明",
                State = "正式會員"
            });
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 3,
                Email = "789@gmail.com",
                Password = "123456",
                Name = "小張",
                NickName = "賣記憶體的小張",
                State = "正式會員"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                UserId = 1,
                Id = 1,
                Name = "貓貓",
                CreateTime = DateTime.Now,
                Description = "不知道可不可以吃",
                Category = "食品",
                Content = "不知道可不可以吃的貓咪",
                Disable = false,
                Price = 50,
                Total = 1000,
                EndTime = DateTime.Now.AddDays(5)
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                UserId = 2,
                Id = 2,
                Name = "鮭魚",
                CreateTime = DateTime.Now,
                Description = "便宜好吃的鮭魚",
                Category = "食品",
                Content = "可以吃的生鮮鮭魚",
                Disable = false,
                Price = 50,
                Total = 500,
                EndTime = DateTime.Now.AddDays(6)
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                UserId = 3,
                Id = 3,
                Name = "記憶體",
                CreateTime = DateTime.Now,
                Description = "記憶體是要描述什麼",
                Category = "3C",
                Content = "便宜好用ㄉ記憶體",
                Disable = false,
                Price = 3000,
                Total = 10000,
                EndTime = DateTime.Now.AddDays(3)
            });

            modelBuilder.Entity<ProductPic>().HasData(new ProductPic()
            {
                Id=1,
                ProductId = 1,
                PicPath = "DEMO喵喵.jpg"
            });
            modelBuilder.Entity<ProductPic>().HasData(new ProductPic()
            {
                Id = 2,
                ProductId = 2,
                PicPath = "DEMO鮭魚.jpg"
            });
            modelBuilder.Entity<ProductPic>().HasData(new ProductPic()
            {
                Id = 3,
                ProductId = 3,
                PicPath = "DEMO記憶體.jpg"
            });





            base.OnModelCreating(modelBuilder);
        }
    }
}
