using System;

class IntDoubleOrString
{
    static void Main()
    {
        Console.WriteLine("Enter a number from 1 to 3 for int,double or string:");
        int client = int.Parse(Console.ReadLine());
        switch (client)
        {
            case 1:
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a+1);
                break;
            case 2:
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b+1);
                break;
            case 3:
                string c = Console.ReadLine();
                Console.WriteLine(c + "*");
                break;
        }
    }
}

