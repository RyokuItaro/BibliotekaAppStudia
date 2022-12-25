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
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<FileEntity> Files { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<QueueEntity> Queues { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        public DbSet<TicketEntity> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //seed tags
            builder.Entity<TagEntity>().HasData(new TagEntity
            {
                TagId = Guid.NewGuid(),
                Name = "Broń"
            });

            builder.Entity<TagEntity>().HasData(new TagEntity
            {
                TagId = Guid.NewGuid(),
                Name = "Magia"
            });

            builder.Entity<TagEntity>().HasData(new TagEntity
            {
                TagId = Guid.NewGuid(),
                Name = "Krew"
            });

            builder.Entity<TagEntity>().HasData(new TagEntity
            {
                TagId = Guid.NewGuid(),
                Name = "Psychologiczne"
            });

            builder.Entity<TagEntity>().HasData(new TagEntity
            {
                TagId = Guid.NewGuid(),
                Name = "Historia polska"
            });

            builder.Entity<TagEntity>().HasData(new TagEntity
            {
                TagId = Guid.NewGuid(),
                Name = "Historia zagraniczna"
            });

            //seed categories
            builder.Entity<CategoryEntity>().HasData(new CategoryEntity
            {
                CategoryId = Guid.NewGuid(),
                Name = "Fantastyka"
            });

            builder.Entity<CategoryEntity>().HasData(new CategoryEntity
            {
                CategoryId = Guid.NewGuid(),
                Name = "Horror"
            });

            builder.Entity<CategoryEntity>().HasData(new CategoryEntity
            {
                CategoryId = Guid.NewGuid(),
                Name = "Sci-Fi"
            });

            builder.Entity<CategoryEntity>().HasData(new CategoryEntity
            {
                CategoryId = Guid.NewGuid(),
                Name = "Historyczne"
            });

            //seed posts
            builder.Entity<PostEntity>().HasData(new PostEntity
            {
                PostId = Guid.NewGuid(),
                Title = "Lorem ipsum dolor sit amet",
                Content = "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.",
                CreatedOn = DateTime.Now
            });
            builder.Entity<PostEntity>().HasData(new PostEntity
            {
                PostId = Guid.NewGuid(),
                Title = "Lorem ipsum dolor sit amet",
                Content = "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.",
                CreatedOn = DateTime.Now
            });
            builder.Entity<PostEntity>().HasData(new PostEntity
            {
                PostId = Guid.NewGuid(),
                Title = "Lorem ipsum dolor sit amet",
                Content = "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.",
                CreatedOn = DateTime.Now
            });
            builder.Entity<PostEntity>().HasData(new PostEntity
            {
                PostId = Guid.NewGuid(),
                Title = "Lorem ipsum dolor sit amet",
                Content = "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.",
                CreatedOn = DateTime.Now
            });
        }
    }
}
