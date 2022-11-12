using BibliotekaMVCApp.Models.Book;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Category
{
    public class CategoryEntity
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public List<BookEntity> Books { get; set; }
    }
}
