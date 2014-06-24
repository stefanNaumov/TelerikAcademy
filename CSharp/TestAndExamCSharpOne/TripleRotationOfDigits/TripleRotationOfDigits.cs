using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleRotationOfDigits
{
    class TripleRotationOfDigits
    {
        static void Main()
        {
            string number = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                
                    number = number[number.Length - 1] + number;
                    number = number.Remove(number.Length - 1);
                
                if (number[0] == '0')
                {
                    number = number.Remove(0,1);
                }
            }
            Console.WriteLine(number);
            
        }
    }
}
