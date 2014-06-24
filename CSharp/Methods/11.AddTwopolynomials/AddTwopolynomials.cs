using System;
using System.Collections.Generic;


//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:

class AddTwoPolynomials
{
    static void Main()
    {
        decimal[] first = new decimal[] { 2, 0, 3, 4 };
        decimal[] second = new decimal[] { 1, 2, 3, 4, 5, 6 };
        decimal[] result = SumPolynomials(first, second);
        PrintPolynomial(result);
    }
    static void PrintPolynomial(decimal[] array)
    {
        for (int i = array.Length-1; i >= 0 ; i--)
        {
            Console.Write(array[i] + "*x^" + i + (i == 0 ? "\n" : " " + "+" + " "));
        }
    }
    static decimal[] SumPolynomials(decimal[] firstArr,decimal[] secondArr)
    {
        if(firstArr.Length > secondArr.Length)
        {
            return SumPolynomials(secondArr, firstArr);
        }
        decimal[] result = new decimal[secondArr.Length];
        int position = 0;

        for (; position < firstArr.Length; position++)
        {
            result[position] = firstArr[position] + secondArr[position];
        }

        for (;position < secondArr.Length; position++)
        {
            result[position] = secondArr[position];
        }
        return result;
    }
}

