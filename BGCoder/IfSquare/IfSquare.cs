using System;



class IfSquare
{
    static void Main()
    {
        Console.WriteLine("Enter side A:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B:");
        int b = int.Parse(Console.ReadLine());
        int result = a * b;
        if (a == b)
        {
            Console.WriteLine(result + "kvadrat");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}

