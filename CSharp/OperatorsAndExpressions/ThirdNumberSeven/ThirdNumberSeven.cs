using System;



class ThirdNumberSeven
{
    static void Main()
    {
        Console.WriteLine("Write a number:");
        int ifThirdNumSeven = int.Parse(Console.ReadLine());
        int firstDivide = ifThirdNumSeven / 100;
        int secondDivide = firstDivide % 10;
        Console.WriteLine(secondDivide==7 ? "The third number is seven":"The third number is not seven");
    }
}

