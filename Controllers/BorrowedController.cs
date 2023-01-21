using BibliotekaMVCApp.Helpers;
using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.BorrowCartItem;
using BibliotekaMVCApp.Models.Db;
using BibliotekaMVCApp.Models.User;
using BibliotekaMVCApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Controllers
{
    [Authorize]
    public class BorrowedController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IBorrowCartItemRepository borrowCartItemRepository;
        private readonly UserManager<UserEntity> _userManager;
        private readonly IBookRepository bookRepository;

        public BorrowedController(AppDbContext context, IBorrowCartItemRepository borrowCartItemRepository, UserManager<UserEntity> userManager, IBookRepository bookRepository)
        {
            _context = context;
            this.borrowCartItemRepository = borrowCartItemRepository;
            _userManager = userManager;
            this.bookRepository = bookRepository;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            var user = await _userManager.GetUserAsync(User);
            if(user == null)
            {
                return NotFound();
            }
            var borrowedBooks = _context.BorrowCartItems.Include(b => b.Book).Where(b => b.UserId == user.Id);
            var pageSize = 10;
            return View(new BorrowedBooksViewModel()
            {
                BorrowedBooks = PaginatedList<BorrowCartItemEntity>.Create(borrowedBooks, pageNumber ?? 1, pageSize)
            });
        }

        public async Task<IActionResult> Cancel(Guid? id)
        {
            if(id == null)
            {
                NotFound();
            }

            var borrow = await _context.BorrowCartItems
                .Include(b => b.Book)
                .FirstOrDefaultAsync(m => m.BorrowCartItemId == id);

            if (borrow == null)
            {
                return NotFound();
            }

            return View(borrow);
        }

        [HttpPost, ActionName("Cancel")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CancelConfirm(Guid id)
        {
            var borrow = await _context.BorrowCartItems.FindAsync(id);
            borrow.Status = Models.BorrowCartItem.Status.Cancelled;
            bookRepository.AddBookAmount(borrow.BookId, borrow.ItemCount);
            _context.BorrowCartItems.Update(borrow);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
