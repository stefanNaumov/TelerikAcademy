using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Implement SortableCollection.BinarySearch() method using binary search algorithm
//Implement SortableCollection.Shuffle() method using shuffle algorithm of your choice
//Document what is the complexity of the algorithm

namespace SortableCollection
{
    class MainLoader
    {
        static void Main()
        {
            List<int> list = new List<int>();
            InsertSortedNumbers(list, 100000000);

            SortableCollection<int> sortableCollection = new SortableCollection<int>(list);
            int target = sortableCollection.BinarySearch(50000000);
            Console.WriteLine(target);

        }

        private static void InsertSortedNumbers(IList<int> collection, int count)
        {
            for (int i = 0; i < count; i++)
            {
                collection.Add(i);
            }
        }
    }

}
