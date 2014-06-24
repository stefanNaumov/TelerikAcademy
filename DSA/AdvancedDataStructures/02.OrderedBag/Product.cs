using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OrderedBag
{
    class Product: IComparable<Product>
    {
        private string name;
        private double price;
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public double Price
        {
            get { return this.price; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public int CompareTo(Product other)
        {
            if (this.Price > other.Price)
            {
                return -1;
            }
            if (this.Price < other.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
