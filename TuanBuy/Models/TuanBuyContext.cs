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
        public virtual DbSet<TestProduct> TestProducts { get; set; }

        public virtual DbSet<ChatRoom> ChatRooms { get; set; }

        public virtual DbSet<ChatRoomMember> Member_Chats { get; set; }

        public virtual DbSet<ChatMessages> ChatMessages { get; set; }

        public virtual DbSet<ProductSellerReply> ProductSellerReplies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatRoomMember>().ToTable("Member_Chats");
            modelBuilder.Entity<ChatRoomMember>().HasKey(s => new { s.MemberId, s.ChatRoomId });

            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                Email = "123@gmail.com",
                Password = "123456",
                Name = "小王",
                NickName = "小王",
                State = "正式會員"
            });
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 2,
                Email = "456@gmail.com",
                Password = "123456",
                Name = "小明",
                NickName = "小明",
                State = "正式會員"
            });
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 3,
                Email = "789@gmail.com",
                Password = "123456",
                Name = "小張",
                NickName = "小張",
                State = "正式會員"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                UserId = 1,
                Id = 1,
                Name = "測試商品1",
                CreateTime = DateTime.Now,
                Description = "商品描述",
                Category = "測試類別",
                Content = "商品內容"
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                UserId = 1,
                Id = 2,
                Name = "測試商品2",
                CreateTime = DateTime.Now,
                Description = "商品描述",
                Category = "測試類別",
                Content = "商品內容"
            });
            modelBuilder.Entity<Product>().HasData(new Product()
            {
                UserId = 1,
                Id = 3,
                Name = "測試商品3",
                CreateTime = DateTime.Now,
                Description = "商品描述",
                Category = "測試類別",
                Content = "商品內容"
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
