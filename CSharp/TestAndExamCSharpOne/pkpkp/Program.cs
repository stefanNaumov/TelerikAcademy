using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < a; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
                Console.Write(i + "+");
            }
        }
        Console.WriteLine("=" + sum);
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        DateTime years = DateTime.Now;
        Console.WriteLine(years.AddYears(5));
    }
}

