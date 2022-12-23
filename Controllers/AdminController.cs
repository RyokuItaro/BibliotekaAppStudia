using BibliotekaMVCApp.Models.Db;
using Microsoft.AspNetCore.Mvc;
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
    }
}
