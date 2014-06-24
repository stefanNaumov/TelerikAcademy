using System;
using System.Collections.Generic;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.



class SqrtOfInteger
{
    static void Main()
    {
        try
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            int num = Int32.Parse(number);
            CheckIfNegative(num);
            int result = num * num;
            Console.WriteLine("Parsing succesfull, result is {0} ", result);
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Number is not in a valid format!" + fe.Message);
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }

    }
    static void CheckIfNegative(int num)
    {
        if (num < 0)
        {
            throw new ArgumentOutOfRangeException("The number must be positive!");
        }
    }

}

