using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main()
        {
            char bit = char.Parse(Console.ReadLine());
            uint N = uint.Parse(Console.ReadLine());
            uint[] numbers = new uint[N];

            //fill the array

            for (int i = 0; i < N; i++)
            {
                numbers[i] = uint.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                string currNumber = Convert.ToString(numbers[i], 2);
                int counter = 0;
                for (int j = 0; j < currNumber.Length; j++)
                {
                    if (currNumber[j] == bit)
                    {
                        counter++;
                    }
                }
                Console.WriteLine(counter);
            }


            //Console.WriteLine(counter);
            //int a = 64;
            //Console.WriteLine(Convert.ToString(a,2));
                    
        }
    }
}
