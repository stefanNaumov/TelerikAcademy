using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] sheets = new int[] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
            List<int> unused = new List<int>();

            for (int i = 0; i < sheets.Length; i++)
            {
                if (n >= sheets[i])
                {
                    n -= sheets[i];
                }
                else
                {
                    unused.Add(i);
                }
            }
            for (int i = 0; i < unused.Count; i++)
            {
                Console.WriteLine("A{0}",unused[i]);
            }
        }
    }
}
