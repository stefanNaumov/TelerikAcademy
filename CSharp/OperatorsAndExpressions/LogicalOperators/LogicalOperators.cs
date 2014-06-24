using System;



class LogicalOperators
{
    static void Main()
    {
        int a = 5;
        int b = 5;
        Console.WriteLine(a|b);
        Console.WriteLine(a<b?"a is smaller than b":"b is smaller than a");
        int p = 5;
        int n = 35;
        int Mask = ~(1 << p);
        int nandMask = n & Mask;
        int bit = nandMask >> p;
        Console.WriteLine(bit);
        Console.WriteLine(Convert.ToString(35,2));
        int c = 4;
        int d = 5;
        Console.WriteLine(c+1>=d);
        Console.WriteLine(c>=d);
        int g = 4;
        Console.WriteLine(g*=5);
        Console.WriteLine(g+=5);
        int? x = 4;
        int y = x ?? 5;
        Console.WriteLine(y);
        Console.WriteLine(typeof(short));
        Console.WriteLine(y is string);
        string first = null;
        string final = first??  "Empty";
        Console.WriteLine(final);
        decimal one = (decimal) Math.PI;
        Console.WriteLine(one);
        string input = "";

        while (input.Length < 4 || input.Length > 4)
        {

            Console.WriteLine("Моля въведете четирицифрено число:");

            input = Console.ReadLine();

        }
    }
}

