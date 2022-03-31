using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TuanBuy.Models.Entities
{
    [Table("User")]

    public partial class User
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string NickName { get; set; } = "別名";
        public string Name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime? Birth { get; set; }
        public string Phone { get; set; }
        public string BankAccount { get; set; }
        public int State { get; set; } = 0;
        public int Sex { get; set; } = 1;
        public string Address { get; set; }
        public string PicPath { get; set; } = "637843188933582087init.jpg";
        public bool Disable { get; set; } = false;
        public string Friend { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        //public virtual Role Role { get; set; }
        //public List<ChatRoomTest> ChatRoomTest { get; set; } = new List<ChatRoomTest>();
        public virtual ICollection<ChatRoom> ChatRoom { get; set; }
    }
}
