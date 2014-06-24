using System;

    class ThirdBitOfInteger
    {
        static void Main()
        {
            int position = 4;
            Console.WriteLine("Write a number:");
            int number = int.Parse(Console.ReadLine());
            int mask = ~(1 << position);
            int NandMask = number & mask;
            int result = NandMask >> position;
            Console.WriteLine(result==0?"The bit is 0":"The bit is 1");
        }
    }

