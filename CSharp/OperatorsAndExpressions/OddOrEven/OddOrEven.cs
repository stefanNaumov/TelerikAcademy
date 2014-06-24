using System;



class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Please enter a number to check if it is odd or even");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(number%2==0? "the number is even":"the number is odd");
    }
}

