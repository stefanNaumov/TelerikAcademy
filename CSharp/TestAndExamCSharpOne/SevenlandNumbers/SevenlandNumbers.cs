using System;


namespace SevenlandNumbers
{
    class SevenlandNumbers
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());

            if (k >= 100 && k < 666)
            {
                if ((k/10)%10 == 6 && k % 10 == 6)
                {
                    k += 34;
                }
                else if (k % 10 == 6)
                {
                    k += 4;
                }
                else
                {
                    k += 1;
                }
            }
            
            else if (k >= 10 && k <= 66)
            {
                if (k % 10 == 6 && (k/10)% 10 == 6)
                {
                    k += 34;
                }
                
                if (k % 10 == 6 && (k / 10) % 10 < 6)
                {
                    k += 4;
                }
                else
                {
                    k += 1;
                }
            }
            else if (k < 10)
            {
                if (k < 6)
                {
                    k += 1;
                }
                else if (k == 6)
                {
                    k += 4;
                }

            }
            else if (k == 666)
            {
                k += 334;
            }
            else
            {
                k += 1;
            }
            Console.WriteLine(k);
        }
    }
}
