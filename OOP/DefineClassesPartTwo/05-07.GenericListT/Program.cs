using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListT
{
    class Program
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(4);
            int capacity = list.ListLength;
            for (int i = 0; i <= capacity + 4; i++)
            {
                list.AddElement(i + 5);
            }
            //list.RemoveElement(1);
            list.InsertAt(432, 1);
            int elementAtIndex = list.GetElementByValue(432);
            for (int i = 0; i < list.ListLength; i++)
            {
                Console.Write("Element {0}: ",i + 1);
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("Element index {0}",elementAtIndex);
            Console.WriteLine("Array doubled length {0}",list.ListLength);
            Console.WriteLine("Minimal element: {0}",list.Min<int>());
            Console.WriteLine("Max element: {0}",list.Max<int>());
            //list.ClearList();
        }
    }
}
