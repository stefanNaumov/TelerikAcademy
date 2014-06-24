using System;


class SumOfFiveNumbers
{
    static void Main()
    {
        int intA, intB, intC, intD, intE;
        bool bolA;
        Console.WriteLine("First number:");
        string a = Console.ReadLine();
        bolA = int.TryParse(a,out intA);
        while (bolA == false) 
        {
            return [0];
        }
    }
}