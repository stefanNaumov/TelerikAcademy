using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.Data;
using BookStore.Models;
using BookStore.Xml;

namespace BookStore.ConsoleClient
{
    class ConsoleClientLoader
    {
        static void Main()
        {
            BookStoreDbContext dbContext = new BookStoreDbContext();
            XmlImporter xmlImporter = new XmlImporter(dbContext);
            string filePath = @"../../../complex-books.xml";
            xmlImporter.Import(filePath);
            Console.WriteLine("Imported complex-books.xml data into database");
            dbContext.SaveChanges();
        }
    }
}
