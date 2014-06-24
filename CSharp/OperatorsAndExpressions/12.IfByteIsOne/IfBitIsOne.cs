using System;


class IfBitIsOne
{
    static void Main()
    {
        Console.WriteLine("Please enter number:");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the position you want to check:");
        int pos = int.Parse(Console.ReadLine());
        int mask = 1 << pos;
        int nandMask = num & mask;
        int result = nandMask >> pos;
        bool isOne = (result == 1);
        Console.WriteLine("Is the bit you checked 1: {0}",isOne);
    }
}
