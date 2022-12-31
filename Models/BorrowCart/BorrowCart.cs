using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.BorrowCartItem;
using BibliotekaMVCApp.Models.Db;
using BibliotekaMVCApp.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.BorrowCart
{
    public class BorrowCart
    {
        private readonly AppDbContext appDbContext;
        public string BorrowCartId { get; set; }

        public List<BorrowCartItemEntity> BorrowCartItems { get; set; }

        public BorrowCart(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public static BorrowCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId.ToString());

            return new BorrowCart(context) { BorrowCartId = cartId };
        }

        public void AddToCart(BookEntity book, int amount)
        {
            var borrowCartItem = appDbContext.BorrowCartItems
                .SingleOrDefault(x => x.Book.BookId == book.BookId && x.BorrowCartId == BorrowCartId);

            if(borrowCartItem == null)
            {
                borrowCartItem = new BorrowCartItemEntity
                {
                    BorrowCartId = BorrowCartId,
                    Book = book,
                    ItemCount = 1
                };

                appDbContext.BorrowCartItems.Add(borrowCartItem);
            }
            else
            {
                borrowCartItem.ItemCount++;
            }

            appDbContext.SaveChanges();
        }

        public int RemoveFromCart(BookEntity book)
        {
            var borrowCartItem = appDbContext.BorrowCartItems
                .SingleOrDefault(x => x.Book.BookId == book.BookId && x.BorrowCartId == BorrowCartId);

            var tmpAmount = 0;

            if(borrowCartItem != null)
            {
                if(borrowCartItem.ItemCount > 1)
                {
                    borrowCartItem.ItemCount--;
                    tmpAmount = borrowCartItem.ItemCount;
                }
                else
                {
                    appDbContext.BorrowCartItems.Remove(borrowCartItem);
                }
            }

            appDbContext.SaveChanges();

            return tmpAmount;
        }

        public List<BorrowCartItemEntity> GetBorrowCartItems()
        {
            return BorrowCartItems ?? (BorrowCartItems =
                appDbContext.BorrowCartItems
                    .Where(x => x.BorrowCartId == BorrowCartId)
                    .Include(x => x.Book)
                    .ToList()
                );
        }
        
        public void ClearCart()
        {
            BorrowCartItems.Clear();
        }
    }
}
