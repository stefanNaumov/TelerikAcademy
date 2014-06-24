using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAllloveBits
{
    class WeAllloveBits
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                string currNumber = Convert.ToString(numbers[i], 2);
                string inverted = invert(currNumber);
                int inv = Convert.ToInt32(inverted, 2);
                string reverse = reversed(currNumber);
                int rev = Convert.ToInt32(reverse, 2);
                int result = ((numbers[i] ^ inv) & rev);
                Console.WriteLine(result);

            }

        }

        static string invert(string converted)
        {
            char[] convertTocharArr = converted.ToCharArray();
            char[] invertedCharArr = new char[convertTocharArr.Length];
            for (int i = 0; i < convertTocharArr.Length; i++)
            {
                if (converted[i] == '0')
                {
                    invertedCharArr[i] = '1';
                }
                else if (converted[i] == '1')
                {
                    invertedCharArr[i] = '0';
                }
            }
            //StringBuilder builder = new StringBuilder();
            string builder = "";
            for (int i = 0; i < invertedCharArr.Length; i++)
            {
                builder += invertedCharArr[i];
                //builder = builder.Append(invertedCharArr[i]);
            }
            return builder;
        }
        static string reversed(string converted)
        {
            char[] convertToCharArr = converted.ToCharArray();
            Array.Reverse(convertToCharArr);
            string result = "";
            for (int i = 0; i < convertToCharArr.Length; i++)
            {
                result += convertToCharArr[i];
            }
            return result;
        }
    }
}