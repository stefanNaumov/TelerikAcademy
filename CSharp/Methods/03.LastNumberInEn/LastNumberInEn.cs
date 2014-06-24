using System;
using System.Collections.Generic;

//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".


class LastNumberInEn
{
    static void Main()
    {
        Console.Write("Enter number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("The last number is: ");
        NameOfLastNumber(number);
    }
    static void NameOfLastNumber(int number)
    {
        string numberToString = number.ToString();
        int lastNumber = numberToString[numberToString.Length - 1]-48;
        switch (lastNumber)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
        }
    }
}

