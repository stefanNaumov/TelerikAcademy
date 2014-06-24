using System;


namespace _09.FirstTenNumbersOfSequence
{
    class FirstTenNumbersOfSequence
    {
        static void Main()
        {
            int a = 2;
            int b = -3;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} {1} ",a,b);
                a = a + 2;
                b = b - 2;
            }
        }
    }
}
