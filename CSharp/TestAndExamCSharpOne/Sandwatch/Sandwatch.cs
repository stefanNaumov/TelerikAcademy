using System;

class Sandwatch

{
    static void Main()
{
        int n;
        Console.WriteLine("Enter an even number N:");
        n = int.Parse(Console.ReadLine());
        if (!(n % 2 == 0) && n < 101)
    {
        for (int row = 0; row < n / 2; row++)
        {
            int dot = row;
            int stars = n - 2 * dot;
            Console.Write(new string('.', dot));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', dot));
            Console.WriteLine();
        }

        for (int row = n / 2; row >= 0; row--)
        {
            int dot = row;
            int stars = n - 2 * dot;
            Console.Write(new string('.', dot));
            Console.Write(new string('*', stars));
            Console.Write(new string('.', dot));
            Console.WriteLine();
        }
    }
        else
        {
            Console.WriteLine("N must be an even number and smaller than 101!");
        }
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
}
}

