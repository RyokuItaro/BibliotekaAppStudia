using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Book
{
    public interface IBookRepository
    {
        public List<BookEntity> GetAllBooks();
    }
}
