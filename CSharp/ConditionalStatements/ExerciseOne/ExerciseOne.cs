using System;

class ExerciseOne
{
    static void Main()
    {
        Console.WriteLine("Enter number of a day from the week [1....7]");
        int Day = int.Parse(Console.ReadLine());
        switch (Day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wensday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Fuck Off!");
                break;
        }
    }
}

