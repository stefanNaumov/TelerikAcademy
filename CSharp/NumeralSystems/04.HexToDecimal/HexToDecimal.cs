using System;
using System.Collections.Generic;


class HexToDecimal
{
    static void Main()
    {
        string number = "FF";
        Console.WriteLine(HexadecimalToDecimal(number));
    }
    static int HexadecimalToDecimal(string number)
    {
        int result = 0;
        int power = number.Length-1;
        for (int i = 0; i < number.Length; i++)
        {
            //using the ASCII table
            if (number[i] > 57)
            {
                result += ((number[i] - 55)*(int)Math.Pow(16,power));
            }
            else
            {
                result += ((number[i]-48) * (int)Math.Pow(16, power));
            }
            power--;
        }
        
        return result;
    }
}

