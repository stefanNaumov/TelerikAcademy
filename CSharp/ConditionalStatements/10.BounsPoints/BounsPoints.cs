using System;

class BounsPoints
{
    static void Main()
    {
        Console.WriteLine("Please enter how many points you have:");
        int points = int.Parse(Console.ReadLine());
        switch (points)
        {
            case 1:
                Console.WriteLine(points * 10);
                break;
            case 2:
                Console.WriteLine(points * 10);
                break;
            case 3:
                Console.WriteLine(points * 10);
                break;
            case 4:
                Console.WriteLine(points * 100);
                break;
            case 5:
                Console.WriteLine(points * 100);
                break;
            case 6:
                Console.WriteLine(points * 100);
                break;
            case 7:
                Console.WriteLine(points * 1000);
                break;
            case 8:
                Console.WriteLine(points * 1000);
                break;
            case 9:
                Console.WriteLine(points * 1000);
                break;
            default:
                Console.WriteLine("Not Valid!");
                break;
        }
    }
}

