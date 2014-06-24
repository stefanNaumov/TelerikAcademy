using System;

namespace _13.NullValues
{
    class NullValues
    {
        static void Main()
        {
            int? a = null;
            double? b = null;
            Console.WriteLine(a + b);
            Console.WriteLine(a - 5);
            Console.WriteLine(b*10);
        }
    }
}
