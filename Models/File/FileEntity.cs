using BibliotekaMVCApp.Models.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.File
{
    public class FileEntity
    {
        [Key]
        public Guid FileId { get; set; }
        public Guid BookId { get; set; }
        [ForeignKey("BookId")]
        public BookEntity Book { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
