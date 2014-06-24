using System;

class Toto6Ot42
{
    static void Main()
    {
        int counter = 0;
        for (int a = 1; a <= 37; a++)
        {
            for (int b = a + 1; b <= 38; b++)
            {
                for (int c = b + 1; c <= 39; c++)
                {
                    for (int d = c + 1; d <= 40; d++)
                    {
                        for (int e = d + 1; e <= 41; e++)
                        {
                            for (int f = e + 1; f <= 42; f++)
                            {
                                //This will print all the combinations
                                //Console.Write("{0} {1} {2} {3} {4} {5}", a, b, c, d, e, f);
                                //Console.Write("\r");
                                //Console.WriteLine();
                                counter++;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine("combinations: {0}",counter);
    }
}

