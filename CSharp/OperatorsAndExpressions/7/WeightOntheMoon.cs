using System;


class WeightOntheMoon
{
    static void Main()
    {
        Console.WriteLine("Моля въведете вашето лично тегло:");
        int KG = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Това ще бъде вашето тегло на Луната:");
        Console.WriteLine(KG*0.17);
    }
}

