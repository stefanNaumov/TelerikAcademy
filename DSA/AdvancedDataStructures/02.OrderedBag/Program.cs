using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;
using System.Diagnostics;

namespace _02.OrderedBag
{
    class Program
    {
        static void Main()
        {
            OrderedBag<Product> bag = new OrderedBag<Product>();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            AddElements(bag, 500000);
            watch.Stop();
            Console.WriteLine("Time for adding 500 000 elements in OrderedBag: {0}",watch.Elapsed);
            //search for elements
            List<Product> elementsInRange = new List<Product>();
            watch.Reset();
            watch.Restart();
            for (int i = 1; i <= 10000; i++)
            {
                int minPrice = i * 2;
                int maxPrice = i * 5;
                Product min = new Product(i.ToString(),(double)minPrice);
                Product max = new Product(i.ToString(),(double)maxPrice);
                elementsInRange.AddRange(bag.Range(min, true, max, true));
            }
            watch.Stop();
            Console.WriteLine("Elapsed time for 10 000 price range searches: {0}",watch.Elapsed);
            
        }
        static void AddElements(OrderedBag<Product> bag, int numberOfElements)
        {
            Random generator = new Random();

            for (int i = 0; i < numberOfElements; i++)
            {
                double price = generator.Next(1, 1000000);
                bag.Add(new Product(i.ToString(),price));
            }
        }
        
    }
}
