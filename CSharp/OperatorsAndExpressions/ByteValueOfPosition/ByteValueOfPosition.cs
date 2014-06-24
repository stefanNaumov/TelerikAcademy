using System;


class ByteValueOfPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter number");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the position you want to check:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nandMask = mask & n;
        int result = nandMask >> p;
        Console.WriteLine("The value of the position is {0}",result);
    }
}

