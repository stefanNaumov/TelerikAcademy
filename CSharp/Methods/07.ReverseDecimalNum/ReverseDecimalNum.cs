using System;
using System.Collections.Generic;

//Write a method that reverses the digits of given decimal number. Example: 256  652


class ReverseDecimalNum
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        number = ReverseDecimal(number);
        Console.WriteLine(number);
    }
    static decimal ReverseDecimal(decimal number)
    {
        string decimalToStr = number.ToString();
        string strToReverse = "";
        for (int i = decimalToStr.Length-1; i >= 0; i--)
        {
            strToReverse += decimalToStr[i];
        }
        decimal result = Convert.ToDecimal(strToReverse);
        return result;
    }
}

