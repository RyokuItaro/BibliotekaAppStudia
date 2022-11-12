using BibliotekaMVCApp.Models.Category;
using BibliotekaMVCApp.Models.File;
using BibliotekaMVCApp.Models.Queue;
using BibliotekaMVCApp.Models.Tag;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Book
{
    public class BookEntity
    {
        [Key]
        public Guid BookId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public int BookCount { get; set; }
        public Status Status { get; set; }
        public int PageCount { get; set; }
        public string AuthorFullname { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public CategoryEntity Category { get; set; }
        public List<TagEntity> Tags { get; set; }
        public List<FileEntity> Files { get; set; }
        public Guid QueueId { get; set; }
        public QueueEntity Queue { get; set; }
    }
}
