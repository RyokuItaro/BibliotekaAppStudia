using BibliotekaMVCApp.Models;
using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.Post;
using BibliotekaMVCApp.Models.User;
using BibliotekaMVCApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository postRepository;
        private readonly IBookRepository bookRepository;
        private readonly UserManager<UserEntity> userManager;

        public HomeController(IPostRepository postRepository, UserManager<UserEntity> userManager, IBookRepository bookRepository)
        {
            this.postRepository = postRepository;
            this.userManager = userManager;
            this.bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            return View(new HomeViewModel
            {
                Posts = postRepository.GetAllPosts(),
                RecentlyAddedBooks = bookRepository.GetAllBooks()
                    .OrderByDescending(b => b.CreatedOn)
                    .Take(5)
                    .ToList()
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
