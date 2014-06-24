using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartEnd
{
    class StartEndReadN
    {
        static void Main()
        {
            int a = StartEndRead(1, 10);
            Console.WriteLine(a);
        }
        
        static int StartEndRead(int start, int end)
        {
            int aftercheck = 0;
            for (int i  = start; i  < end; i ++)
            {
                int read = int.Parse(Console.ReadLine());
                int afterCheck = IfBetweenStartEnd(start, end, read);
            }
            return aftercheck;
        }
        static int IfBetweenStartEnd(int start, int end, int number)
        {
            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException("The number is out of the allowed range");
            }
            return number;
        }
    }
}
