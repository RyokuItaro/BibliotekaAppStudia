﻿using BibliotekaMVCApp.Models.Db;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Book
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List<BookEntity> GetAllBooks()
        {
            var books = appDbContext.Books.Include(b => b.Category).ToList();
            return books;
        }
    }
}
