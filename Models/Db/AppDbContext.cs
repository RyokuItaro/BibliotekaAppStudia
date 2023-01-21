using BibliotekaMVCApp.Models.Book;
using BibliotekaMVCApp.Models.Category;
using BibliotekaMVCApp.Models.BorrowCartItem;
using BibliotekaMVCApp.Models.Post;
using BibliotekaMVCApp.Models.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BibliotekaMVCApp.Models.Db
{
    public class AppDbContext : IdentityDbContext<UserEntity>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<BookEntity> Books { get; set; }
        public DbSet<BorrowCartItemEntity> BorrowCartItems { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<Config> Config { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            EnsureDefaultConfigExists(builder);

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

        protected void EnsureDefaultConfigExists(ModelBuilder builder)
        {
            builder.Entity<Config>().HasData(new Config
            {
                ConfigId = Guid.NewGuid(),
                Key = "maxBorrowDaysAllowed",
                Value = "30"
            });

            builder.Entity<Config>().HasData(new Config
            {
                ConfigId = Guid.NewGuid(),
                Key = "maxDaysToRetrieve",
                Value = "3"
            });
        }
    }
}
