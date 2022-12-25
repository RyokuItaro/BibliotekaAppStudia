using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.BorrowCart;
using BibliotekaMVCApp.ViewModels;
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
        private readonly BorrowCart borrowCart;

        public BorrowCartController(IBookRepository bookRepository, BorrowCart borrowCart)
        {
            this.bookRepository = bookRepository;
            this.borrowCart = borrowCart;
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
    }
}
