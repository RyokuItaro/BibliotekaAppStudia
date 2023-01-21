﻿// <auto-generated />
using System;
using BibliotekaMVCApp.Models.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BibliotekaMVCApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230102155331_AddedCreatedOnAttributeOnBookAndDaysOfWaiting")]
    partial class AddedCreatedOnAttributeOnBookAndDaysOfWaiting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BibliotekaMVCApp.Models.Book.BookEntity", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorFullname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("BookCount")
                        .HasColumnType("int");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("QueueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.BorrowCartItem.BorrowCartItemEntity", b =>
                {
                    b.Property<Guid>("BorrowCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BorrowCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BorrowedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DaysOfWaiting")
                        .HasColumnType("int");

                    b.Property<int>("DaysToReturn")
                        .HasColumnType("int");

                    b.Property<int>("ItemCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BorrowCartItemId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("BorrowCartItems");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Category.CategoryEntity", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("a8695201-7668-486c-b43a-f88807daf1a1"),
                            Name = "Fantastyka"
                        },
                        new
                        {
                            CategoryId = new Guid("8646ef51-90bb-413d-b06c-fa7e89f35bda"),
                            Name = "Horror"
                        },
                        new
                        {
                            CategoryId = new Guid("e3620e81-f31c-4706-b68e-95a7c48956ee"),
                            Name = "Sci-Fi"
                        },
                        new
                        {
                            CategoryId = new Guid("c7583933-ea4a-43fd-966c-a499c525a8ac"),
                            Name = "Historyczne"
                        });
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Db.Config", b =>
                {
                    b.Property<Guid>("ConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConfigId");

                    b.ToTable("Config");

                    b.HasData(
                        new
                        {
                            ConfigId = new Guid("b88a9145-b41c-4b4a-8553-0674795fd3f1"),
                            Key = "maxBorrowDaysAllowed",
                            Value = "30"
                        });
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.File.FileEntity", b =>
                {
                    b.Property<Guid>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FileId");

                    b.HasIndex("BookId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Post.PostEntity", b =>
                {
                    b.Property<Guid>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = new Guid("9ea809aa-fd93-4328-a557-8d929cd69810"),
                            Content = "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.",
                            CreatedOn = new DateTime(2023, 1, 2, 16, 53, 30, 633, DateTimeKind.Local).AddTicks(2747),
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            PostId = new Guid("1505ea3e-bd1d-4381-aa9c-82cc3c347dfe"),
                            Content = "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.",
                            CreatedOn = new DateTime(2023, 1, 2, 16, 53, 30, 635, DateTimeKind.Local).AddTicks(7608),
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            PostId = new Guid("24748a34-b3af-4603-b9a8-7bc4ad635a24"),
                            Content = "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.",
                            CreatedOn = new DateTime(2023, 1, 2, 16, 53, 30, 635, DateTimeKind.Local).AddTicks(7654),
                            Title = "Lorem ipsum dolor sit amet"
                        },
                        new
                        {
                            PostId = new Guid("95c2d554-07cd-413b-8199-e5ad00630f96"),
                            Content = "Sed feugiat cursus volutpat. Sed et sollicitudin felis. In ut nisl eu elit maximus interdum. Fusce laoreet vitae diam sed viverra. Duis laoreet, lacus at facilisis venenatis, urna mauris egestas dolor, id consectetur ante eros id diam. Praesent varius non nibh ut egestas. Vivamus pulvinar nisi id diam aliquet lobortis. Duis ornare ligula pulvinar pharetra sollicitudin. Quisque ut sapien nec leo auctor sollicitudin. Lorem ipsum dolor sit amet, consectetur adipiscing elit. In efficitur tortor id odio fringilla, a egestas erat ultrices. Vestibulum gravida neque congue blandit viverra. Proin eget leo lectus. Etiam sem sem, porta rutrum dolor id, rutrum semper mauris. Integer sed fringilla turpis. Duis cursus sit amet risus ac aliquet.",
                            CreatedOn = new DateTime(2023, 1, 2, 16, 53, 30, 635, DateTimeKind.Local).AddTicks(7685),
                            Title = "Lorem ipsum dolor sit amet"
                        });
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Queue.QueueEntity", b =>
                {
                    b.Property<Guid>("QueueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("QueueId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("Queues");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Tag.TagEntity", b =>
                {
                    b.Property<Guid>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            TagId = new Guid("3146654b-f357-4b88-98a5-4dd8a9bd3174"),
                            Name = "Broń"
                        },
                        new
                        {
                            TagId = new Guid("d12de02b-6f96-492e-87bd-2edf8c40fee8"),
                            Name = "Magia"
                        },
                        new
                        {
                            TagId = new Guid("6424c18b-9bab-48b5-94d3-df7b43514229"),
                            Name = "Krew"
                        },
                        new
                        {
                            TagId = new Guid("d157727c-137e-43a4-a424-13dfa54e147b"),
                            Name = "Psychologiczne"
                        },
                        new
                        {
                            TagId = new Guid("01fff746-7471-4f0c-88c9-9c5f39a49552"),
                            Name = "Historia polska"
                        },
                        new
                        {
                            TagId = new Guid("2235164c-b93a-4809-8b8b-3815a9b69bca"),
                            Name = "Historia zagraniczna"
                        });
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Ticket.TicketEntity", b =>
                {
                    b.Property<Guid>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BorrowCartItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ForfeitValue")
                        .HasColumnType("real");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TicketId");

                    b.HasIndex("BorrowCartItemId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.User.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("VisibleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BookEntityTagEntity", b =>
                {
                    b.Property<Guid>("BooksBookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagsTagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BooksBookId", "TagsTagId");

                    b.HasIndex("TagsTagId");

                    b.ToTable("BookEntityTagEntity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("QueueEntityUserEntity", b =>
                {
                    b.Property<Guid>("QueuesQueueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("QueuesQueueId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("QueueEntityUserEntity");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Book.BookEntity", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.Category.CategoryEntity", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.BorrowCartItem.BorrowCartItemEntity", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.Book.BookEntity", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BibliotekaMVCApp.Models.User.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.File.FileEntity", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.Book.BookEntity", "Book")
                        .WithMany("Files")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Post.PostEntity", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.User.UserEntity", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Queue.QueueEntity", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.Book.BookEntity", "Book")
                        .WithOne("Queue")
                        .HasForeignKey("BibliotekaMVCApp.Models.Queue.QueueEntity", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Ticket.TicketEntity", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.BorrowCartItem.BorrowCartItemEntity", "BorrowedBook")
                        .WithMany()
                        .HasForeignKey("BorrowCartItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BibliotekaMVCApp.Models.User.UserEntity", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId");

                    b.Navigation("BorrowedBook");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookEntityTagEntity", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.Book.BookEntity", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BibliotekaMVCApp.Models.Tag.TagEntity", null)
                        .WithMany()
                        .HasForeignKey("TagsTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.User.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.User.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BibliotekaMVCApp.Models.User.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.User.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QueueEntityUserEntity", b =>
                {
                    b.HasOne("BibliotekaMVCApp.Models.Queue.QueueEntity", null)
                        .WithMany()
                        .HasForeignKey("QueuesQueueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BibliotekaMVCApp.Models.User.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Book.BookEntity", b =>
                {
                    b.Navigation("Files");

                    b.Navigation("Queue");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.Category.CategoryEntity", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BibliotekaMVCApp.Models.User.UserEntity", b =>
                {
                    b.Navigation("Posts");

                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}