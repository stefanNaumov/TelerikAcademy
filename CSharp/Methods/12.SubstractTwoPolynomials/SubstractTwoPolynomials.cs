using System;
using System.Collections.Generic;

//Extend the program to support also subtraction and multiplication of polynomials.


class SubstractTwoPolynomials
{
    static void Main()
    {
        decimal[] first = new decimal[] { 1, 2, 3, 4, 5, 6 };
        decimal[] second = new decimal[] { 2, 0, 3, 4 };
        decimal[] result = SubstractPolynomials(first, second);
        PrintPolynomials(result);

    }
    static void PrintPolynomials(decimal[] array)
    {
        for (int i = array.Length-1; i >= 0; i--)
        {
            Console.Write(array[i] + "*x^" + i + (i == 0 ? "\n" : " + "));
        }
    }
    static decimal[] SubstractPolynomials(decimal[] first,decimal[] second)
    {
        decimal[] result = new decimal[Math.Max(first.Length,second.Length)];
        

        if(first.Length >= second.Length)
        {
            int position = 0;
            for (; position < second.Length; position++)
            {
                result[position] = first[position] - second[position];
            }
            for (; position < first.Length; position++)
            {
                result[position] = first[position];
            }
        }

        else if (first.Length < second.Length)
        {
            int position = 0;
            for (; position < first.Length; position++)
            {
                result[position] = first[position] - second[position];
            }
            for (; position < second.Length; position++)
            {
                result[position] = second[position];
            }
        }
        return result;
    }
}

