using System;
using System.Collections.Generic;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0


class SeveralTasks
{
    static void Main()
    {
        string enter = "";
        Console.Write("Enter 1 for reversing a number,\nEnter 2 for calculating the average from a sequence \nEnter 3 for linear equation: ");
        enter = Console.ReadLine();
        if(enter == "1")
        {
            Console.Write("Enter a number which you would like to reverse:");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal result = ReverseNumber(number);
            Console.WriteLine("Reversed the number is: {0}",result);
        }
        if(enter == "2")
        {
            Console.WriteLine("Enter the sequence of numbers and when ready press /0000/");
            int exit = 0; ;
            List<int> numbers = new List<int>();
            int count = -1;
            do
            {
                Console.Write("Enter number {0}: ",count+2);
                exit = int.Parse(Console.ReadLine());
                numbers.Add(exit);
                count++;
                
            }
            while (exit != 0000);
            if(count == 0)
            {
                Console.WriteLine("Sequence must have at least 1 element!");
                return;
            }
            int result = AverageFromSequence(numbers);
            Console.WriteLine("The average from your sequence is: {0}",result);
        }
        if(enter == "3")
        {
            Console.Write("Enter number a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b: ");
            int b = int.Parse(Console.ReadLine());

            double result = LinearEquation(a, b);
            Console.WriteLine(result);
        }
        
    }
    static decimal ReverseNumber(decimal number)
    {
        string numberToStr = number.ToString();
        string reversed = "";
        for (int i = numberToStr.Length-1; i >= 0; i--)
        {
            reversed += numberToStr[i];
        }
        return Convert.ToDecimal(reversed);
    }

    static int AverageFromSequence(List<int> integers)
    {
        int sum = 0;
        for (int i = 0; i < integers.Count; i++)
        {
            sum += integers[i];
        }
        int result = sum / integers.Count;
        return result;
    }
    static double LinearEquation(int a,int b)
    {
        double x = (double)-b / a;
        return x;
    }
}

