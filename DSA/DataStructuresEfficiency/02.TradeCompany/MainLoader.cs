using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

//A large trade company has millions of articles, each described by barcode, vendor, title and price.
//Implement a data structure to store them that allows fast retrieval of all articles in given price range [x…y].
//Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET. 

namespace TradeCompany
{
    public class MainLoader
    {
        static void Main()
        {
            OrderedMultiDictionary<Article, int> articles = new OrderedMultiDictionary<Article, int>(true);
            Random priceGen = new Random();
            for (int i = 0; i < 1000; i++)
            {
                Article article = new Article(12345678, "Mente" + i, "ArticleTitle" + i, priceGen.Next(100, 10000));
                articles.Add(article,1);
            }
            decimal minPrice = 100;
            decimal maxPrice = 5500;
            OrderedMultiDictionary<Article, int>.View priceRangedArticles = articles.Range(
                new Article(0, " ", " ", minPrice), true,
                new Article(0, " ", " ", maxPrice), true);

            foreach (var article in priceRangedArticles)
            {
                Console.WriteLine(article.Key.Price);
            }
        }
    }
}
