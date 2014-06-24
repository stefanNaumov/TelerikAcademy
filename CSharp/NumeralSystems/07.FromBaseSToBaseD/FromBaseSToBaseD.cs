using System;
using System.Collections.Generic;


//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).


class Program
{
    static void Main()
    {
        Console.Write("Enter number:");
        string number = Console.ReadLine();
        int toDecimal = ConvertToDec(number, 2);
        Console.Write("Enter base:");
        int newBase = int.Parse(Console.ReadLine());
        string result = FromDecToAny(toDecimal, newBase);
        Console.WriteLine("The number {0} converted in base {1} is {2}",number,newBase,result);
    }

    //first convert to decimal

    static int ConvertToDec(string number, int D)
    {
        int result = 0;
        //reverse the string
        string reversed = "";
        for (int i = number.Length - 1; i >= 0; i--)
        {
            reversed += number[i];
        }
        //Convert to Decimal
        for (int i = 0; i < reversed.Length; i++)
        {
            if(reversed[i] > 47 && reversed[i] < 58)
            {
                result += (int)((reversed[i] - 48) * Math.Pow(D, i));
            }
            else if(reversed[i] > 64 && reversed[i] < 91)
            {
                result += (int)((reversed[i] - 55) * Math.Pow(D,i));
            }
        }
        return result;
    }

    //Then convert from decimal to any base

    static string FromDecToAny(int number,int Base)
    {
        string tempResult = "";

        while(number > 0)
        {
            int rem = number % Base;
            if (rem >= 9)
            {
                tempResult += (char)(rem + 55);
            }
            else
            {
                tempResult += rem;
            }
            number = number / Base;
        }
        //reverse the result
        string result = "";
        for (int i = tempResult.Length-1; i >= 0; i--)
        {
            result += tempResult[i];
        }
        return result;
    }
    
}

