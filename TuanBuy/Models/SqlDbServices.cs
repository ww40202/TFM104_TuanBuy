using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuanBuy.Models.Entities;

namespace TuanBuy.Models
{
    public class SqlDbServices : DbContext
    {
        public SqlDbServices(DbContextOptions<SqlDbServices> _options) : base(_options) { }


        public DbSet<User> Members { get; set; }

        public DbSet<ChatRoom> ChatRooms { get; set; }

        public DbSet<ChatRoomMember> Member_Chats { get; set; }

        public DbSet<ChatMessages> ChatMessages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatRoomMember>().HasKey(s => new { s.MemberId, s.ChatRoomId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
