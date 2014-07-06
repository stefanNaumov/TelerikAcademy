using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal sequence of equal elements in an array.
//        Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

namespace _04.MaxSeqOfEqulElements
{
    class EqualElementsSeq
    {
        static void Main()
        {
            int[] array = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            
            int maxSeqCounter = 0;
            int maxSeqElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                int currSeqElement = array[i];
                int seqCounter = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] != currSeqElement)
                    {
                        break;
                    }
                    seqCounter++;
                }

                if (seqCounter > maxSeqCounter)
                {
                    maxSeqCounter = seqCounter;
                    maxSeqElement = currSeqElement;
                }
            }
            Console.Write("Max sequence of equal elements is: ");
            Console.WriteLine(String.Concat(Enumerable.Repeat(maxSeqElement,maxSeqCounter)));
        }
    }
}
