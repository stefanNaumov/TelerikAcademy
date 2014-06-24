using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelColumns
{
    class ExcelColumns
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long result = 0;
            for (int i = 0; i < n; i++)
            {
                result = (result + Console.ReadLine()[0] - 64) * 26;
            }
            Console.WriteLine(result/26);

            //int num = int.Parse(Console.ReadLine());
            //long sum = 0;

            //for (int i = num - 1; i >= 0; i--)
            //{
            //    int letter = char.Parse(Console.ReadLine()) - 64;
            //    long value = (long)(Math.Pow(26, i));
            //    sum += letter * value;
            //}
            //Console.WriteLine(sum);

            //for (int i = 0; i <= num - 1; i++)
            //{
            //    int letter = char.Parse(Console.ReadLine()) - 64;
            //    long value = (long)(Math.Pow(26, i));
            //    sum += letter * value;
            //}
            //Console.WriteLine(sum);
        }
    }
}
