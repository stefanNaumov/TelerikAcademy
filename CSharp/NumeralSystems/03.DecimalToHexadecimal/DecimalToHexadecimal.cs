using System;
using System.Collections.Generic;

//Write a program to convert decimal numbers to their hexadecimal representation.


class DecimalToHexadecimal
{
    static void Main()
    {
        int number = 38790;
        Console.WriteLine(DecimalToHex(number));
    }
    static string DecimalToHex(int number)
    {
        string result = "";
        while(number != 0)
        {
            int res = number % 16;
            if (res > 9)
            {
                result += (char)(res + 55); //using the ASCII table
            }
            else
            {
                result += res;
            }
            number /= 16;
        }
        string final = "";
        for (int i = result.Length-1; i >= 0; i--)
        {
            final += result[i];
        }
        return final;

    }

}

