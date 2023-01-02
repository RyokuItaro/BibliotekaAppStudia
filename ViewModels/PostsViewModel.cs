using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.ViewModels
{
    public class HomeViewModel
    {
        public List<PostEntity> Posts { get; set; }
        public List<BookEntity> RecentlyAddedBooks { get; set; }
    }
}
