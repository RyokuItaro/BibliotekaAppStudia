using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ManageBooks()
        {
            var appDbContext = _context.Books.Include(b => b.Category);
            return View(await appDbContext.ToListAsync());
        }

        public IActionResult ManageClients()
        {
            return View();
        }

        public IActionResult ManageEmployees()
        {
            return View();
        }

        public IActionResult ManageRules()
        {
            return View();
        }

        public async Task<IActionResult> BookDetails(Guid? id)
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

        public IActionResult BookCreate()
        {
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BookCreate([Bind("BookId,PublishDate,Isbn,Title,BookCount,Status,PageCount,AuthorFullname,CategoryId,QueueId")] BookEntity bookEntity)
        {
            if (ModelState.IsValid)
            {
                bookEntity.BookId = Guid.NewGuid();
                _context.Add(bookEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManageBooks));
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
            return View(bookEntity);
        }

        public async Task<IActionResult> BookEdit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookEntity = await _context.Books.FindAsync(id);
            if (bookEntity == null)
            {
                return NotFound();
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
            return View(bookEntity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BookEdit(Guid id, [Bind("BookId,Isbn,Title,BookCount,Status,PageCount,AuthorFullname,CategoryId,QueueId")] BookEntity bookEntity)
        {
            if (id != bookEntity.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookEntityExists(bookEntity.BookId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ManageBooks));
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
            return View(bookEntity);
        }

        public async Task<IActionResult> BookDelete(Guid? id)
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

        [HttpPost, ActionName("BookDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BookDeleteConfirmed(Guid id)
        {
            var bookEntity = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ManageBooks));
        }

        private bool BookEntityExists(Guid id)
        {
            return _context.Books.Any(e => e.BookId == id);
        }
    }
}
