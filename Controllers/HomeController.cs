using BibliotekaMVCApp.Models;
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
        private readonly UserManager<UserEntity> userManager;

        public HomeController(IPostRepository postRepository, UserManager<UserEntity> userManager)
        {
            this.postRepository = postRepository;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(new PostsViewModel
            {
                Posts = postRepository.GetAllPosts()
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
