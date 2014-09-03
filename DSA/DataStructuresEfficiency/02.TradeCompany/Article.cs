using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCompany
{
    public class Article : IComparable<Article>
    {
        public int Barcode { get; private set; }
        public string Vendor { get; private set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }

        public Article(int barcode, string vendor, string title, decimal price)
        {
            this.Barcode = barcode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
