using System;

class NameOfInteger
{
    static void Main()
    {
        Console.WriteLine("Enter a number from 0...9 which name in Bulgarian you want to see:");
        int name = int.Parse(Console.ReadLine());
        switch (name)
        {
            case 0:
                Console.WriteLine("Нула");
                break;
            case 1:
                Console.WriteLine("Едно");
                break;
            case 2:
                Console.WriteLine("Две");
                break;
            case 3:
                Console.WriteLine("Три");
                break;
            case 4:
                Console.WriteLine("Четири");
                break;
            case 5:
                Console.WriteLine("Пет");
                break;
            case 6:
                Console.WriteLine("Шест");
                break;
            case 7:
                Console.WriteLine("Седем");
                break;
            case 8:
                Console.WriteLine("Осем");
                break;
            case 9:
                Console.WriteLine("Девет");
                break;
            default:
                Console.WriteLine("Number must be in the range 0 - 9!");
                break;
        }
    }
}

