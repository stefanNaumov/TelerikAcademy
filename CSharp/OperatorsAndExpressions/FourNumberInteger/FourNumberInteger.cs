using System;


class FourNumberInteger
{
    static void Main()
    {
        string input ="";
        while (input.Length < 4 || input.Length > 4)
        {
            Console.WriteLine("Моля въведете четирицифрено число:");
            input=Console.ReadLine();
        }
        int value = Convert.ToInt32(input);
        int a = value/ 1000;
        int b = (value / 100) % 10;
        int c = (value % 100) / 10;
        int d = value % 10;
        Console.WriteLine("Сборът на отделните цифри е:");
        Console.WriteLine(a + b + c + d);
        Console.WriteLine("Изписано наобратно числото е:");
        Console.Write(d);
        Console.Write(c);
        Console.Write(b);
        Console.WriteLine(a);
        Console.WriteLine("С последна цифра поставена като първа числото изглежда така:");
        Console.Write(d);
        Console.Write(a);
        Console.Write(b);
        Console.WriteLine(c);
        Console.WriteLine("С разменени втора и трета цифра числото изглежда така:");
        Console.Write(a);
        Console.Write(c);
        Console.Write(b);
        Console.WriteLine(d);
    }
}

