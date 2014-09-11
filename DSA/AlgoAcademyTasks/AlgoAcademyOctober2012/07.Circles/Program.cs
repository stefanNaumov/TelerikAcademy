using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Circles
{
    class Program
    {
        static char[] permutationsArray;
        static bool[] usedChars;
        static string strInput;

        static void Main()
        {
            strInput = Console.ReadLine();
            
            permutationsArray = new char[strInput.Length];

            usedChars = new bool[strInput.Length];
       
           CountPermutations(0);
        }

        static void CountPermutations(int index)
        {
            if (index >= permutationsArray.Length)
            {
                for (int i = 0; i < permutationsArray.Length; i++)
                {
                    Console.Write(permutationsArray[i]);
                }

                Console.WriteLine();

                return;
            }

            for (int i = 0; i < strInput.Length; i++)
            {
                if (usedChars[i] == false)
                {
                    usedChars[i] = true;
                    permutationsArray[index] = (char)strInput[i];
                    CountPermutations(index + 1);
                    usedChars[i] = false;
                }
            }
        }
    }
}
