using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that removes from given sequence all numbers that occur odd number of times. Example:
//{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}

namespace RemoveNegativeNumbers
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[] { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i],0);
                }
                dict[arr[i]]++;
            }
            foreach (var number in dict.Where(num => num.Value % 2 == 0).ToList())
            {
                dict.Remove(number.Key);
            }

            foreach (var number in dict)
            {
                Console.WriteLine(number.Key + " -> appears " + number.Value + " times");
            }
        }
    }
}
