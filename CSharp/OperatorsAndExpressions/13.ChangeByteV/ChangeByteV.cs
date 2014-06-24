using System;

class ChangeByteV
{
    static void Main()
    {
        Console.WriteLine("Моля въведете число:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Моля въведете коя позиция искате да бъде променена:");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Моля въведете стойност на бита:");
        int input = int.Parse(Console.ReadLine());
        if (input <= -1 || input >= 2)
            Console.WriteLine("Моля въведете 1 или 0");
        if (input == 0)
        {
            Console.WriteLine("After changing the bit,the value will be {0}",(~(1<<position)&number));
        }
        if (input == 1)
        {
            Console.WriteLine("After changing the bit,the value will be {0}",(1<<position)|number);
        }
        
    }      
}

