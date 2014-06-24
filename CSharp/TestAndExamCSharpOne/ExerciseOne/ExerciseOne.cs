using System;
using System.Numerics;
class ExerciseOne
{
    static void Main()
    {
        //Console.WriteLine("Enter number:");
        //int n = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter position:");
        //int p = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter value:");
        //int v = int.Parse(Console.ReadLine());
        //if (v == 1)
        //{
        //    int mask = n;
        //    int Nandmask = mask | (1 << p);
        //    Console.WriteLine(Nandmask);
        //}
        //if (v == 0)
        //{
        //    int mask = n;
        //    int NandMask = mask & (~(1 << p));
        //    Console.WriteLine(NandMask);
        //}
        Console.Write("Enter number N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter number K: ");
        int numberK = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        for (int n = 1; n < numberN + 1; n++)
        {
            factorialN *= n;
        }
        for (int k = 1; k < numberK + 1; k++)
        {
            factorialK *= k;
        }

        if (1 < numberK && numberK < numberN)
        {
            BigInteger result = (factorialN / factorialK);
            Console.WriteLine("For N = {1} and K = {2}\nN! / K! = {0}", result, numberN, numberK);
        }
        else
        {
            Console.WriteLine("Invalid input. Let 1<N<K");
            Main();
        }




    }
}

