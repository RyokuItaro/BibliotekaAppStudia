using BibliotekaMVCApp.Models.BorrowCartItem;
using BibliotekaMVCApp.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.BorrowCart
{
    public class BorrowCartEntity
    {
        [Key]
        public Guid BorrowCartId { get; set; }
        public DateTime CreatedOn { get; set; }
        public Status Status { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public UserEntity User { get; set; }
        public List<BorrowCartItemEntity> BorrowCartItems { get; set; }
    }
}
