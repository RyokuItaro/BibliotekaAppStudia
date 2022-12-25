using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.BorrowCart;
using BibliotekaMVCApp.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.BorrowCartItem
{
    public class BorrowCartItemEntity
    {
        [Key]
        public Guid BorrowCartItemId { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime ReturnedDate { get; set; }
        public int ItemCount { get; set; }
        public Status Status { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public UserEntity User { get; set; }
        public Guid BookId { get; set; }
        [ForeignKey("BookId")]
        public BookEntity Book { get; set; }
        public Guid BorrowCartId { get; set; }
        [ForeignKey("BorrowCartId")]
        public BorrowCart.BorrowCart BorrowCart { get; set; }
    }
}
