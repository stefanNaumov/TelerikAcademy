using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that compares two char arrays lexicographically (letter by letter).
namespace _03.CompareTwoCharArrays
{
    class CompareTwoCharArr
    {
        static void Main()
        {
            bool areLexicographicallyEqual = true;
            Console.Write("Enter chars of the first array:");
            string firstArrString = Console.ReadLine();
            Console.Write("Enter chars of the second array:");
            string secondArrString = Console.ReadLine();


            char[] firstArray = firstArrString.ToCharArray();
            char[] secondArray = secondArrString.ToCharArray();

            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        areLexicographicallyEqual = false;
                        break;
                    }
                }
            }
            else
            {
                areLexicographicallyEqual = false;
            }

            Console.WriteLine("The two arrays are lexicographically equal: {0}",areLexicographicallyEqual);
        }
    }
}
