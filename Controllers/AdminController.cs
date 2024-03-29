﻿using BibliotekaMVCApp.Helpers;
using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.BorrowCartItem;
using BibliotekaMVCApp.Models.Db;
using BibliotekaMVCApp.Models.Post;
using BibliotekaMVCApp.Models.User;
using BibliotekaMVCApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
    [Authorize]
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IBookRepository bookRepository;
        private readonly UserManager<UserEntity> userManager;

        public AdminController(AppDbContext context, IBookRepository bookRepository, UserManager<UserEntity> userManager)
        {
            _context = context;
            this.bookRepository = bookRepository;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var currUser = await userManager.GetUserAsync(User);
            if(currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            return View();
        }

        public async Task<IActionResult> ManageBooks(int? pageNumber)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            var books = _context.Books.Include(b => b.Category);
            return View(PaginatedList<BookEntity>.Create(books, pageNumber ?? 1, 10));
        }

        public async Task<IActionResult> ManagePosts()
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            var posts = await _context.Posts.ToListAsync();
            return View(posts);
        }

        public async Task<IActionResult> ManageBorrows(int? pageNumber)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            var borrowedBooks = _context.BorrowCartItems.Include(b => b.User).Include(b => b.Book).OrderByDescending(b => b.BorrowedDate);
            return View(new BorrowedBooksViewModel()
            {
                BorrowedBooks = PaginatedList<BorrowCartItemEntity>.Create(borrowedBooks, pageNumber ?? 1, 10)
            });
        }

        #region Books
        public async Task<IActionResult> BookDetails(Guid? id)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
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

        public async Task<IActionResult> BookCreate()
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BookCreate([Bind("BookId,PublishDate,Isbn,Title,BookCount,Status,PageCount,AuthorFullname,CategoryId,QueueId")] BookEntity bookEntity)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            if (ModelState.IsValid)
            {
                bookEntity.BookId = Guid.NewGuid();
                bookEntity.CreatedOn = DateTime.Now;
                _context.Add(bookEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManageBooks));
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name");
            return View(bookEntity);
        }

        public async Task<IActionResult> BookEdit(Guid? id)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
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
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            if (id != bookEntity.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    bookEntity.Category = _context.Categories.FirstOrDefault(c => c.CategoryId == bookEntity.CategoryId);
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
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
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
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            var bookEntity = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookEntity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ManageBooks));
        }

        private bool BookEntityExists(Guid id)
        {
            return _context.Books.Any(e => e.BookId == id);
        }
        #endregion

        #region Posts
        public async Task<IActionResult> PostCreate()
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostCreate([Bind("PostId, Title, Content, CreatedOn, UserId")] PostEntity postEntity)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            if (ModelState.IsValid)
            {
                postEntity.PostId = Guid.NewGuid();
                postEntity.CreatedOn = DateTime.Now;
                _context.Add(postEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManagePosts));
            }

            return View(postEntity);
        }
        public async Task<IActionResult> PostEdit(Guid? id)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostEdit(Guid id, [Bind("PostId, Title, Content, CreatedOn, UserId")] PostEntity postEntity)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            if (id != postEntity.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Posts.Any(p => p.PostId == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ManagePosts));
            }

            return View(postEntity);
        }

        public async Task<IActionResult> PostDelete(Guid? id)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .FirstOrDefaultAsync(p => p.PostId == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        [HttpPost, ActionName("PostDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PostDeleteConfirmed(Guid id)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            var post = await _context.Posts.FindAsync(id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ManagePosts));
        }
        #endregion

        #region Borrowed Books
        public async Task<IActionResult> BorrowEdit(Guid? id)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            if (id == null)
            {
                return NotFound();
            }

            var borrowedEntity = _context.BorrowCartItems.Include(b => b.Book).FirstOrDefault(b => b.BorrowCartItemId == id);
            if (borrowedEntity == null)
            {
                return NotFound();
            }
            return View(borrowedEntity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BorrowEdit(Guid id, [Bind("BorrowCartItemId,DaysOfWaiting,DaysToReturn,Status,BookId,UserId,BorrowedDate,ReturnedDate,ItemCount")] BorrowCartItemEntity borrowedEntity)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            if (id != borrowedEntity.BorrowCartItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if(borrowedEntity.Status == Models.BorrowCartItem.Status.Returned)
                    {
                        var book = bookRepository.AddBookAmount(borrowedEntity.BookId, borrowedEntity.ItemCount);
                    }
                    _context.BorrowCartItems.Update(borrowedEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (_context.BorrowCartItems.Any(e => e.BorrowCartItemId == borrowedEntity.BorrowCartItemId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ManageBorrows));
            }
            return View(borrowedEntity);
        }

        public async Task<IActionResult> BorrowDelete(Guid? id)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            if (id == null)
            {
                return NotFound();
            }

            var borrow = await _context.BorrowCartItems
                .Include(b => b.Book)
                .FirstOrDefaultAsync(p => p.BorrowCartItemId == id);
            if (borrow == null)
            {
                return NotFound();
            }

            return View(borrow);
        }

        [HttpPost, ActionName("BorrowDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BorrowDeleteConfirmed(Guid id)
        {
            var currUser = await userManager.GetUserAsync(User);
            if (currUser.Role != Role.Admin)
            {
                return Forbid();
            }
            var borrowed = await _context.BorrowCartItems.FindAsync(id);
            _context.BorrowCartItems.Remove(borrowed);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ManageBorrows));
        }
        #endregion
    }
}
