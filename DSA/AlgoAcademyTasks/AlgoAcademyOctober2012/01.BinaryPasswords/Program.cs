using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryPasswords
{
    public class Program
    {
        static long currLength = 1;

        static void Main()
        {
            string inputPass = Console.ReadLine();

            CountPassCombinations(0, inputPass);

            Console.WriteLine(currLength);
        }

        static void CountPassCombinations(int index, string password)
        {
            if (index >= password.Length)
            {
                return;
            }

            if (password[index] == '*')
            {
                currLength *= 2;
                CountPassCombinations(index + 1, password);
            }
            else
            {
                CountPassCombinations(index + 1, password);
            }

        }
    }
}
