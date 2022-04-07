using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TuanBuy.Models.Entities;

namespace TuanBuy.Models
{
    [Table("Member_Chats")]
    public class ChatRoomMember
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int MemberId { get; set; }

        [ForeignKey("ChatRoom")]
        public Guid ChatRoomId { get; set; }

        public virtual User User { get; set; }

        public virtual ChatRoom ChatRoom { get; set; }
    }
}
