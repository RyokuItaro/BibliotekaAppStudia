using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.Db;
using BibliotekaMVCApp.Helpers;
using BibliotekaMVCApp.Models.Category;

namespace BibliotekaMVCApp.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Book
        public async Task<IActionResult> Index(int? pageNumber, Guid? categoryId, string isbnFilter, string authorFilter, string titleFilter)
        {
            var books = _context.Books.AsQueryable();

            if(categoryId != null)
            {
                ViewData["CategoryId"] = categoryId;
                books = books.Where(b => b.CategoryId == categoryId);
            }
            if (!String.IsNullOrEmpty(isbnFilter))
            {
                ViewData["ISBNFilter"] = isbnFilter;
                books = books.Where(b => b.Isbn == isbnFilter);
            }
            if (!String.IsNullOrEmpty(authorFilter))
            {
                ViewData["AuthorFilter"] = authorFilter;
                books = books.Where(b => b.AuthorFullname.ToLower().Contains(authorFilter.ToLower()));
            }
            if (!String.IsNullOrEmpty(titleFilter))
            {
                ViewData["TitleFilter"] = titleFilter;
                books = books.Where(b => b.Title.ToLower().Contains(titleFilter.ToLower()));
            }

            var categories = _context.Categories.ToList();

            int pageSize = 5;
            ViewBag.BookCategories = categories;
            return View(PaginatedList<BookEntity>.Create(books, pageNumber ?? 1, pageSize));
        }

        // GET: Book/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookEntity = await _context.Books
                .Include(b => b.Category)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (bookEntity == null)
            {
                return NotFound();
            }

            return View(bookEntity);
        }
    }
}
