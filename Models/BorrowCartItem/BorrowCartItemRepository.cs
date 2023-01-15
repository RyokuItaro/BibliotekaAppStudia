using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.BorrowCartItem
{
    public class BorrowCartItemRepository : IBorrowCartItemRepository
    {
       private readonly AppDbContext appDbContext;

       public BorrowCartItemRepository(AppDbContext appDbContext)
       {
           this.appDbContext = appDbContext;
       }

       public List<BorrowCartItemEntity> GetBorrowedBooks(string userId)
       {
           var borrowedBooks = appDbContext.BorrowCartItems.Where(b => b.UserId == userId).ToList();
           return borrowedBooks;
       }

       public List<BorrowCartItemEntity> GetBorrowedBooks()
       {
            var borrowedBooks = appDbContext.BorrowCartItems.ToList();
            return borrowedBooks;
        }
    }
}
