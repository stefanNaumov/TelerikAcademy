using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Data;
using BookStore.ConsoleClient;
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
                Book book = new Book();

                var bookAuthors = this.ParseAuthors(xmlbook);

                foreach (var bookItem in bookAuthors)
                {
                    book.Authors.Add(bookItem);
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

            foreach (var review in reviews.Elements("review"))
            {
                reviewsList.Add(GetReviewObj(review));
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
            var revAuthor = xmlReview.Attribute("author").Value;
            var revDate = DateTime.Parse(xmlReview.Attribute("date").Value);
            var content = xmlReview.Value;

            Review review = new Review()
            {
                Date = revDate
            };

            if (revAuthor != null)
            {
                review.Author = this.GetAuthor(revAuthor);   
            }

            if (content != null)
            {
                review.Content = content;
            };

            return review;
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
