using System;
using System.Collections.Generic;
using System.Data.Entity;
using BookStore.Models;
using BookStore.Data.Migrations;

namespace BookStore.Data
{
    public class BookStoreDbContext :DbContext
    {
        public BookStoreDbContext()
            : base("BookStore")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookStoreDbContext, Configuration>());
        }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
