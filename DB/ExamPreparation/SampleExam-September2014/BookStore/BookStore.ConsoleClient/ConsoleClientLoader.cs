using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.Data;
using BookStore.Models;

namespace BookStore.ConsoleClient
{
    class ConsoleClientLoader
    {
        static void Main()
        {
            BookStoreDbContext dbContext = new BookStoreDbContext();
            
            dbContext.SaveChanges();
        }
    }
}
