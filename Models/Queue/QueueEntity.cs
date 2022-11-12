using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Queue
{
    public class QueueEntity
    {
        [Key]
        public Guid QueueId { get; set; }
        public Guid BookId { get; set; }
        [ForeignKey("BookId")]
        public BookEntity Book { get; set; }
        public List<UserEntity> Users { get; set; }
    }
}
