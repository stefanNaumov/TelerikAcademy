using System;

namespace _12.ASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
            int max = 255;
            for (int i = 0; i < max; i++)
            {
                char ch = (char)i;
                Console.WriteLine(ch);
            }
        }
    }
}
