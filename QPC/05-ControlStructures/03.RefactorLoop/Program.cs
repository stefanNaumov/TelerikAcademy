using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RefactorLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[1000];
            int expectedValue = 330;
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        i = 666;
                    }

                }

                Console.WriteLine(array[i]);
                if (i == 666)
                {
                    Console.WriteLine("Value Found");
                }
            }
        }
    }
}
