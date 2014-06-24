using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ExchangeThreeBitsOfUInt
{
    class ExchangeThreeBitsOfUInt
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint mask = 1;
            byte firstPosition = 3;
            byte secondPosition = 24;
            uint bitOne, bitTwo;
            uint newNumber = 0;

            for (uint bit = 0; bit < 3; bit++, firstPosition++, secondPosition++)
            {
                mask = mask << firstPosition;
                bitOne = mask & number;
                mask = mask >> firstPosition;

                mask = mask << secondPosition;
                bitTwo = mask & number;
                mask = mask >> secondPosition;
                if (bitOne != bitTwo)
                {
                    if (bitOne == 1)
                    {
                        newNumber = number | (mask << secondPosition);
                        number = newNumber ^ (mask << firstPosition);
                    }
                    else
                    {
                        newNumber = number ^ (mask << secondPosition);
                        number = newNumber | (mask << firstPosition);
                    }
                }
            }
            Console.WriteLine(number);
        }
    }
}
