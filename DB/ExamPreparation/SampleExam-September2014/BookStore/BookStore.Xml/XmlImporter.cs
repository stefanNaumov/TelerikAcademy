using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Data;
using BookStore.Models;
using BookStore.Data;

namespace BookStore.Xml
{
    public class XmlImporter
    {
        private BookStoreDbContext dbContext;

        public XmlImporter(BookStoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Import(string filePath)
        {
            var books = XElement.Load(filePath).Elements("book");
            
            foreach (var xmlbook in books)
            {
                if (xmlbook != null)
                {
                    Book book = new Book();
                    book.Title = xmlbook.Element("title").Value.Trim();
                    var bookAuthors = this.ParseAuthors(xmlbook);

                    foreach (var bookAuthor in bookAuthors)
                    {
                        book.Authors.Add(bookAuthor);
                    }

                    var bookReviews = this.ParseReviews(xmlbook);

                    foreach (var reviewItem in bookReviews)
                    {
                        book.Reviews.Add(reviewItem);
                    }

                    var isbn = xmlbook.Element("isbn");
                    if (isbn != null)
                    {
                        book.ISBN = isbn.Value;
                    }

                    var url = xmlbook.Element("url");
                    if (url != null)
                    {
                        book.WebSite = url.Value;
                    }

                    this.dbContext.Books.Add(book);
                    this.dbContext.SaveChanges(); 
                }
            }
        }

        private ICollection<Author> ParseAuthors(XElement book)
        {
            ICollection<Author> authorsList = new List<Author>();

            var authors = book.Element("authors");
            
            if (authors != null)
            {
                foreach (var author in authors.Elements("author"))
                {
                    authorsList.Add(this.HandleAuthorInput(author));
                }
            }

            return authorsList;
        }

        private ICollection<Review> ParseReviews(XElement book)
        {
            ICollection<Review> reviewsList = new List<Review>();

            var reviews = book.Element("reviews");

            if (reviews != null)
            {
                foreach (var review in reviews.Elements("review"))
                {
                    reviewsList.Add(GetReviewObj(review));
                } 
            }

            return reviewsList;
        }

        private Author HandleAuthorInput(XElement xmlAuthor)
        {
            string authorName = xmlAuthor.Value;
            var author = this.dbContext.Authors.FirstOrDefault(a => a.Name == authorName);
            
            if (author == null)
            {
                author = new Author()
                {
                    Name = authorName
                };
            }
            
            return author;
        }

        private Review GetReviewObj(XElement xmlReview)
        {
            Review reviewObj = new Review();

            var revDate = xmlReview.Attribute("date");
            if (revDate != null)
            {
                reviewObj.Date = DateTime.Parse(revDate.Value);
            }
            else
            {
                reviewObj.Date = DateTime.Now;
            }

            var revAuthor = xmlReview.Attribute("author");
            if (revAuthor != null)
            {
                reviewObj.Author = this.GetAuthor(revAuthor.Value);
            }

            var revContent = xmlReview.Value;
            if (revContent != null)
            {
                reviewObj.Content = revContent;
            }

            return reviewObj;
        }

        private Author GetAuthor(string authorName)
        {
            Author newAuthor = new Author()
            {
                Name = authorName
            };

            return newAuthor;
        }
    }
}
