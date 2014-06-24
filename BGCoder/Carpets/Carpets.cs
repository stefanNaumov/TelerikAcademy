using System;
using System.Collections.Generic;

class Carpets
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0 && n > 6 && n <= 80)
        {
            for (int row = n; row > n / 2-1; row--)
            {
                int dots = row-1;
                dots--;
                int space = n - dots;
                Console.Write(new string('.',dots/2-1));
                Console.Write('/');
                Console.Write(new string(' ',space));
                Console.Write('\\');
                Console.Write(new string('.',dots/2));
                Console.WriteLine();
            }
        }
    }
}

