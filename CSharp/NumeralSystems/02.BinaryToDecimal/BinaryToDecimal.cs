using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;


//Write a program to convert binary numbers to their decimal representation.


namespace _02.BinaryToDecimal
{
    public class BinaryToDecimall
    {
        static void Main()
        {
            string bin = Console.ReadLine();
            int dec = BinaryToDecimal(bin);
            Console.WriteLine(dec);
        }
        static int BinaryToDecimal(string number)
        {
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                result += (number[i] - 48) * (int)Math.Pow(2, number.Length - i - 1);
            }
            return result;
        }
    }
}
