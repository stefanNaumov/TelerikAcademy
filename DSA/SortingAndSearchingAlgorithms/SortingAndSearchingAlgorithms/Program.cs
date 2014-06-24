namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            //var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            var collection = new SortableCollection<int>(new int[10000]);

            Random generator = new Random();


            for (int i = 0; i < 10000; i++)
            {
                int currentNumber = generator.Next(1, 500000);
                collection.Items.Add(currentNumber);
            }
            
            
            ////Console.WriteLine("All items before sorting:");
            //////collection.PrintAllItemsOnConsole();
            ////Console.WriteLine();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("SelectionSorter result:");
            collection.Sort(new SelectionSorter<int>());
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            //collection.PrintAllItemsOnConsole();
            Console.WriteLine();

            //collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101,55,18,3 });
            //collection = new SortableCollection<int>(new[] { 9,8,7,6,5,4,3});
            Console.WriteLine("Quicksorter result:");
            watch.Reset();
            collection.Items.Clear();
            for (int i = 0; i < 10000; i++)
            {
                int currentNumber = generator.Next(1, 500000);
                collection.Items.Add(currentNumber);
            }
            watch.Start();
            collection.Sort(new Quicksorter<int>());
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
            //collection.PrintAllItemsOnConsole();
            Console.WriteLine();

            //collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            //Console.WriteLine("MergeSorter result:");
            //collection.Sort(new MergeSorter<int>());
            //collection.PrintAllItemsOnConsole();
            //Console.WriteLine();

            //Console.WriteLine("Linear search 101:");
            //Console.WriteLine(collection.LinearSearch(101));
            //Console.WriteLine();

            //Console.WriteLine("Binary search 101:");
            //Console.WriteLine(collection.BinarySearch(101));
            //Console.WriteLine();

            //Console.WriteLine("Shuffle:");
            //collection.Shuffle();
            //collection.PrintAllItemsOnConsole();
            //Console.WriteLine();

            //Console.WriteLine("Shuffle again:");
            //collection.Shuffle();
            //collection.PrintAllItemsOnConsole();
        }
    }
}
