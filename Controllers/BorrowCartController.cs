using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.BorrowCart;
using BibliotekaMVCApp.Models.Db;
using BibliotekaMVCApp.Models.User;
using BibliotekaMVCApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Controllers
{
    public class BorrowCartController : Controller
    {
        private readonly IBookRepository bookRepository;
        private readonly IConfigRepository configRepository;
        private readonly BorrowCart borrowCart;
        private readonly UserManager<UserEntity> userManager;
        private readonly AppDbContext _context;

        public BorrowCartController(IBookRepository bookRepository, BorrowCart borrowCart, UserManager<UserEntity> userManager, IConfigRepository configRepository, AppDbContext context)
        {
            this.bookRepository = bookRepository;
            this.borrowCart = borrowCart;
            this.userManager = userManager;
            this.configRepository = configRepository;
            _context = context;
        }

        public ViewResult Index()
        {
            var items = borrowCart.GetBorrowCartItems();
            borrowCart.BorrowCartItems = items;

            var borrowCartViewModel = new BorrowCartViewModel
            {
                BorrowCart = borrowCart,
            };

            return View(borrowCartViewModel);
        }

        public RedirectToActionResult AddToBorrowCart(Guid bookId)
        {
            var selectedBook = bookRepository.GetAllBooks().FirstOrDefault(x => x.BookId == bookId);

            if(selectedBook != null)
            {
                borrowCart.AddToCart(selectedBook, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromBorrowCart(Guid bookId)
        {
            var selectedBook = bookRepository.GetAllBooks().FirstOrDefault(x => x.BookId == bookId);

            if (selectedBook != null)
            {
                borrowCart.RemoveFromCart(selectedBook);
            }
            return RedirectToAction("Index");
        }

        public async Task<RedirectToActionResult> ConfirmBorrowing()
        {
            var borrowCartBooks = borrowCart.GetBorrowCartItems();
            var currUser = await userManager.GetUserAsync(User);
            var daysToReturn = configRepository.GetConfigValueByKey("maxBorrowDaysAllowed");

            if(daysToReturn == String.Empty)
            {
                return RedirectToAction("Index", "Home");
            }

            foreach(var borrowedBook in borrowCartBooks)
            {
                borrowedBook.User = currUser;
                borrowedBook.BorrowedDate = DateTime.Now;
                borrowedBook.DaysToReturn = Convert.ToInt32(daysToReturn);
                borrowedBook.Status = Models.BorrowCartItem.Status.Waiting;
                _context.BorrowCartItems.Update(borrowedBook);
            }

            await _context.SaveChangesAsync();
            borrowCart.ClearCart();
            return RedirectToAction("Index", "Home");
        }
    }
}
