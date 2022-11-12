using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.BorrowCart;
using BibliotekaMVCApp.Models.Category;
using BibliotekaMVCApp.Models.BorrowCartItem;
using BibliotekaMVCApp.Models.File;
using BibliotekaMVCApp.Models.Post;
using BibliotekaMVCApp.Models.Queue;
using BibliotekaMVCApp.Models.Tag;
using BibliotekaMVCApp.Models.Ticket;
using BibliotekaMVCApp.Models.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Db
{
    public class AppDbContext : IdentityDbContext<UserEntity>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<BookEntity> Books { get; set; }
        public DbSet<BorrowCartItemEntity> BorrowCartItems { get; set; }
        public DbSet<BorrowCartEntity> BorrowCarts { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<FileEntity> Files { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<QueueEntity> Queues { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<TicketEntity> Tickets { get; set; }
    }
}
