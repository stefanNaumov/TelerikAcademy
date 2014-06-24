using System;
using System.Collections.Generic;


//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100



class ReadNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        ReadNumber(start, end);
    }
    static void ReadNumber(int start,int end)
    {
        int currentNumber;
        try
        {
            for (int i = 0; i < 10; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < start || currentNumber > end)
                {
                    throw new ArgumentOutOfRangeException("Number is not in the specified range by user");
                    
                }
            }
        }
        catch(FormatException fe)
        {
            throw new FormatException("\n Not valid format,input must be an integer!");
        }
        

    }
}

