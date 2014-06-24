using System;


class int0X
{
    static void Main()
    {
        Console.WriteLine("Write a number:");
        int a = int.Parse(Console.ReadLine());
        string hex = a.ToString("X");
        Console.WriteLine(hex);
    }
}

