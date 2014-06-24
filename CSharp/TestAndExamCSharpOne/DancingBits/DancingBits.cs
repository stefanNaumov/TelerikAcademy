using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DancingBits
{
    class DancingBits
    {
        static void Main()
        {
            int identicalBits = int.Parse(Console.ReadLine());
            int numberOfIntegers = int.Parse(Console.ReadLine());
            
            string[] binary = new string[numberOfIntegers];
            string allBits = null;

            for (int i = 0; i < numberOfIntegers; i++)
            {
                binary[i] = Convert.ToString(int.Parse(Console.ReadLine()),2);
                allBits += binary[i];
            }
            
            char[] charBits = allBits.ToCharArray();

            int tempBits = 1;
            int resultCount = 0;
            for (int i = 1; i < charBits.Length; i++)
            {
                if (charBits[i] == charBits[i - 1])
                {
                    tempBits++;
                }
                else 
                {
                    if (tempBits == identicalBits)
                    {
                        resultCount++;
                    }
                    tempBits = 1;
                }
                if (i == (charBits.Length - 1))
                {
                    if (tempBits == identicalBits)
                    {
                        resultCount++;
                    }
                }
                
            }



            //Console.WriteLine(allBits);
            Console.WriteLine(resultCount);
            
            
        }
    }
}
