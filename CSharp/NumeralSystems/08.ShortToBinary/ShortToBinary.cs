using System;
using System.Collections.Generic;


class ShortToBinary
{
    static void Main()
    {
        short num = short.Parse(Console.ReadLine());
        Console.WriteLine(ShortTobin(num));
    }
    static string ShortTobin(short number)
    {
        string bin = null;

        if (number >= 0)
        {
            string temp = null;
            while (number > 0)
            {
                temp += (number % 2);
                number /= 2;
            }
            //reverse the string
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                bin += temp[i];
            }
        }
        else
        {
            number = (short)(Math.Abs(number) - 1);
            string temp = null;

            while (number > 0)
            {
                temp += (number % 2);
                number /= 2;
            }
            //reverse and invert the string
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                if (temp[i] == '1')
                {
                    bin += "0";
                }
                else
                {
                    bin += "1";
                }
            }
            while (bin.Length % 16 != 0)
            {
                bin = "1" + bin;
            }
        }
        return bin;




    }
}
