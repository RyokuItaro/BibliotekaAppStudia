using BibliotekaMVCApp.Models.BorrowCartItem;
using BibliotekaMVCApp.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Ticket
{
    public class TicketEntity
    {
        [Key]
        public Guid TicketId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public float ForfeitValue { get; set; }
        public Status Status { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public UserEntity User { get; set; }
        public Guid BorrowCartItemId { get; set; }
        [ForeignKey("BorrowCartItemId")]
        public BorrowCartItemEntity BorrowedBook { get; set; }
    }
}
