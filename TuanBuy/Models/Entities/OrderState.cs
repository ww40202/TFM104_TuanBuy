using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuanBuy.Models.Entities
{
    public class OrderState
    {
        [Key]
        public int StateId { get; set; }
        public string State { get; set; }

    }
}