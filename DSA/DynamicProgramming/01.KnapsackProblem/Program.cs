using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.KnapsackProblem
{
    class Program
    {
        static void Main()
        {
            Product[] products = new Product[]
            {
                new Product("beer",3,2),
                new Product("vodka",8,9),
                new Product("cheese",4,5),
                new Product("nuts",1,4),
                new Product("ham",2,3),
                new Product("whiskey",8,13)
            };
            int knapsackCapacity = 10;

            List<Product> optimalCombination = findBestCombination(products, knapsackCapacity);
            foreach (var product in optimalCombination)
            {
                Console.Write(product.Name + " ");
            }
            Console.WriteLine();
        }
        static List<Product> findBestCombination(Product[] products, int knapsackCapacity)
        {
            //rows are for the products and the columns are for capacity calculations
            int[,] valuesArr = new int[products.Length + 1, knapsackCapacity + 1];
            int[,] keepArr = new int[products.Length + 1, knapsackCapacity + 1];

            //solve problem for one element in the array
            for (int i = 1; i <= knapsackCapacity; i++)
            {
                if (products[0].Weight <= i)
                {
                    valuesArr[1, i-1] = products[0].Cost;
                    keepArr[1, i] = 1;
                }
                else
                {
                    valuesArr[1, i] = 0;
                    keepArr[1, i] = 0;
                }
            }

            //fill table
            for (int i = 1; i <= products.Length; i++)
            {
                for (int k = 1; k <= knapsackCapacity; k++)
                {
                    var currProduct = products[i - 1];
                    if (currProduct.Weight <= k)
                    {
                        int previousValue = valuesArr[i - 1, k];
                        int sumValue = currProduct.Cost + valuesArr[i - 1, k - currProduct.Weight];
                        
                        //decide whether to take or not the current product

                        if (previousValue > sumValue)
                        {
                            valuesArr[i, k] = previousValue;
                            keepArr[i, k] = 0;
                        }
                        else
                        {
                            valuesArr[i, k] = sumValue;
                            keepArr[i, k] = 1;
                        }
                    }
                }
            }
            //take out the best combination starting from the bottom right of the table
            List<Product> bestItems = new List<Product>();

            int remainingSpace = knapsackCapacity;
            int items = products.Length;

            while (items >= 0)
            {
                int element = keepArr[items, remainingSpace - 1];
                if (element == 1)
                {
                    bestItems.Add(products[items - 1]);
                    remainingSpace -= products[items-1].Weight;
                }
                items--;
            }

            return bestItems;
        }
    }
}
