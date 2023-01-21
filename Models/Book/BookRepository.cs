using BibliotekaMVCApp.Models.Db;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Book
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List<BookEntity> GetAllBooks()
        {
            var books = appDbContext.Books.Include(b => b.Category).ToList();
            return books;
        }

        public BookEntity RemoveBookAmount(Guid bookId, int quantity)
        {
            var book = appDbContext.Books.FirstOrDefault(x => x.BookId == bookId);
            if(book == null || book.BookCount < quantity)
            {
                return null;
            }

            book.BookCount -= quantity;
            appDbContext.Update(book);
            return book;
        }

        public BookEntity RemoveBookAmount(BookEntity book, int quantity)
        {
            if (book == null || book.BookCount < quantity)
            {
                return null;
            }

            book.BookCount -= quantity;
            appDbContext.Update(book);
            return book;
        }

        public BookEntity AddBookAmount(Guid bookId, int quantity)
        {
            var book = appDbContext.Books.FirstOrDefault(x => x.BookId == bookId);
            if (book == null)
            {
                return null;
            }

            book.BookCount += quantity;
            appDbContext.Update(book);
            return book;
        }

        public BookEntity AddBookAmount(BookEntity book, int quantity)
        {
            if (book == null)
            {
                return null;
            }

            book.BookCount += quantity;
            appDbContext.Update(book);
            return book;
        }
    }
}
