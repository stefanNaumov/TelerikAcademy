using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class Program
    {
        static void Main()
        {
            BitArray64 first = new BitArray64(125);
            foreach (var bit in first)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            BitArray64 second = new BitArray64(123);
            second = new BitArray64(125);
            Console.WriteLine(first.Equals(second));
        }
    }
}
