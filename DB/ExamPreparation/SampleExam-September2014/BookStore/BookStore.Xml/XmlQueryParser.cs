using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Xml.Linq;
using BookStore.Models;
using BookStore.Data;
using System.Text;

namespace BookStore.Xml
{
    public class XmlQueryParser
    {
        private BookStoreDbContext dbContext;

        public XmlQueryParser(BookStoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Search(string filePath)
        {
            var xmlQueries = XElement.Load(filePath).Elements();
            var searchResults = new XElement("search-results");
            foreach (var query in xmlQueries)
            {
                var reviewQueries = dbContext.Reviews.AsQueryable();

                if (query.Attribute("type").Value == "by-period")
                {
                    var startDate = DateTime.Parse(query.Element("start-date").Value);
                    var endDate = DateTime.Parse(query.Element("end-date").Value);

                    reviewQueries.Where(r => r.Date >= startDate && r.Date <= endDate);
                }
                else if (query.Attribute("type").Value == "by-author")
                {
                    var authorName = query.Element("author-name").Value;
                    reviewQueries = reviewQueries.Where(r => r.Author.Name == authorName);
                }

                var resultSet = reviewQueries.OrderBy(r => r.Date).ThenBy(r => r.Content)
                    .Select(r => new
                   {
                       Date = r.Date,
                       Content = r.Content,
                       Book = new
                       {
                           Title = r.Book.Title,
                           Authors = r.Book.Authors
                           .OrderBy(a => a.Name)
                           .Select(a => a.Name),
                           Isbn = r.Book.ISBN,
                           Url = r.Book.WebSite
                       }
                   }).ToList();

                var xmlResultSet = new XElement("result-set");

                foreach (var reviewInResult in resultSet)
                {
                    var foundedReview = new XElement("review");
                    var date = new XElement("date");
                    date.Value = reviewInResult.Date.ToString("d-MMM-yyyy");
                    foundedReview.Add(date);
                    var content = new XElement("content");
                    content.Value = reviewInResult.Content;
                    foundedReview.Add(content);
                    var book = new XElement("book");
                    var title = new XElement("title");
                    title.Value = reviewInResult.Book.Title;
                    book.Add(title);

                    if (reviewInResult.Book.Isbn != null)
                    {
                        var isbn = new XElement("isbn");
                        isbn.Value = reviewInResult.Book.Isbn;
                        book.Add(isbn);
                    }

                    var reviewsCount = reviewInResult.Book.Authors.Count();

                    if (reviewsCount > 0)
                    {
                        var authors = new XElement("authors");
                        StringBuilder authorsNames = new StringBuilder();

                        for (var i = 0; i < reviewsCount; i++)
                        {
                            if (i == reviewsCount - 1)
                            {
                                authorsNames.Append(reviewInResult.Book.Authors.ElementAt(i));
                            }
                            else
                            {
                                authorsNames.Append(reviewInResult.Book.Authors.ElementAt(i) + ", ");
                            }
                        }

                        authors.Value = authorsNames.ToString();
                        book.Add(authors);
                    }

                    foundedReview.Add(book);
                    xmlResultSet.Add(foundedReview);
                }

                searchResults.Add(xmlResultSet);
            }

            Console.WriteLine("Xml queries parsed and data saved int reviews-search-results.xml");
            searchResults.Save(@"..\..\..\reviews-search-results.xml");
        }
    }
}
