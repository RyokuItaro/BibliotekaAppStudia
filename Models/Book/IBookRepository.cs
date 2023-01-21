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
        public BookEntity RemoveBookAmount(Guid bookId, int quantity);
        public BookEntity RemoveBookAmount(BookEntity book, int quantity);
        public BookEntity AddBookAmount(Guid bookId, int quantity);
        public BookEntity AddBookAmount(BookEntity book, int quantity);
    }
}
