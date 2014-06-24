using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NNestedLoops
{
    class Program
    {
        static void Main()
        {
            int numberOfLoops = 3;
            int[] arr = new int[numberOfLoops];
            NestedLoopsGenerator(0, numberOfLoops, arr);
        }
        static void NestedLoopsGenerator(int index, int numberOfLoops, int[] array)
        {
            if (index >= numberOfLoops)
            {
                Console.WriteLine(String.Join(" ",array));
                return;
            }
            for (int i = 1; i < numberOfLoops; i++)
            {
                array[index] = i;
                NestedLoopsGenerator(index + 1, numberOfLoops, array);
            }
        }
    }
}
