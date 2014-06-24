using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Durankulak
{
    class Program
    {
        static void Main()
        {
            string inputNumber = Console.ReadLine();
            if (inputNumber.Length == 1 && inputNumber[0] == '0')
            {
                Console.WriteLine(0);
                return;
            }
            else
            {
                BigInteger durankulakNum = DurankulakConverter(inputNumber);
                Console.WriteLine(durankulakNum); 
            }
        }
        static BigInteger DurankulakConverter(string input)
        {
            BigInteger result = 0;
            BigInteger power = 1;
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1 && char.IsUpper(array[i]) && char.IsLower(array[i+1]))
                {
                    result += ((array[i] - 65) + ((array[i+1] - 96) * 26)) * power;
                    i++;
                }
                else if ((i < array.Length - 1 && char.IsUpper(array[i]) && char.IsUpper(array[i+1])) || (i == array.Length - 1 && char.IsUpper(array[i])))
                {
                    result += (array[i] - 65) * power;
                }
                power *= 168;
            }
            return result;
        }
    }
}