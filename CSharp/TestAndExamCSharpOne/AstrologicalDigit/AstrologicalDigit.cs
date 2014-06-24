using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AstrologicalDigit
{
    class AstrologicalDigit
    {
        static void Main()
        {
            string N = Console.ReadLine();
            N = N.Replace("-","");
            N = N.Replace(".", "");

            //N = N.Replace(" ",string.Empty);
            char[] arr = N.ToCharArray();
            
            long result = 0;

            for (int i = 0; i < N.Length; i++)
            {
                long number = Convert.ToInt32(arr[i]-48);
                result += number;
            }
            while (result > 9)
            {
                long currSum = result % 10;
                result = result / 10;
                result += currSum;
            }
            Console.WriteLine(result);
        }
    }
}
