using System;
using System.Collections.Generic;


//Write a program to convert decimal numbers to their binary representation.


namespace _01.DecimalToBinary
{
    public class DecimalToBinary
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<int> InBinary = new List<int>();
            while (number > 0)
            {
                InBinary.Add(number % 2);
                number = number / 2;
            }

            for (int i = InBinary.Count-1; i >= 0; i--)
            {
                Console.Write(InBinary[i]);
            }
            Console.WriteLine();
            
        }
    }
}
