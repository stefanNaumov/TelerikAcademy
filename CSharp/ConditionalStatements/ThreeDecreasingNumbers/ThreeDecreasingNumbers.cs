using System;

class ThreeDecreasingNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int c = int.Parse(Console.ReadLine());
        if (c > b && c > a)
        {
            int firstNumber = c;
            Console.WriteLine(firstNumber);
            if (b > a)
            {
                int secondNumber = b;
                Console.WriteLine(secondNumber);
                int thirdNumber = a;
                Console.WriteLine(thirdNumber);
            }
            else if (b < a)
            {
                int secondNumber = a;
                Console.WriteLine(secondNumber);
                int thirdNumber = b;
                Console.WriteLine(thirdNumber);
            }
        }
        else if (b > a && b > c)
        {
            int firstNumber = b;
            Console.WriteLine(firstNumber);
            if (a > c)
            {
                int secondNumber = a;
                Console.WriteLine(secondNumber);
                int thirdNumber = c;
                Console.WriteLine(thirdNumber);
            }
            else if (a < c)
            {
                int secondNumber = c;
                Console.WriteLine(secondNumber);
                int thirdnumber = a;
                Console.WriteLine(thirdnumber);
            }
        }
        else if (a > b && a > c)
        {
            int firstNumber = a;
            Console.WriteLine(firstNumber);
            if (b > c)
            {
                int secondNumber = b;
                Console.WriteLine(secondNumber);
                int thirdNumber = c;
                Console.WriteLine(thirdNumber);
            }
            else if (b < c)
            {
                int secondNumber = c;
                Console.WriteLine(secondNumber);
                int thirdNumber = b;
                Console.WriteLine(thirdNumber);
            }
        }
    }
}

