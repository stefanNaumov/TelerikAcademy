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
            string xmlImportFilePath = @"../../../complex-books.xml";
            string xmlQueriesFilePath = @"../../../reviews-queries.xml";
            XmlQueryParser queryParser = new XmlQueryParser(dbContext);
            queryParser.Search(xmlQueriesFilePath);
            XmlImporter xmlImporter = new XmlImporter(dbContext);

            xmlImporter.Import(xmlImportFilePath);
            Console.WriteLine("Imported complex-books.xml data into database");
            dbContext.SaveChanges();
        }
    }
}
