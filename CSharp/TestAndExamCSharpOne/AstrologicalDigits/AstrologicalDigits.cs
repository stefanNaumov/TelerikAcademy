using System;
using System.Collections.Generic;


namespace AstrologicalDigits
{
    class AstrologicalDigits
    {
        static void Main()
        {
            string number = Console.ReadLine().Replace(".","").Replace("-","");
            int sum = 0;
            foreach (char ch in number)
            {
                sum += int.Parse((ch).ToString());
            }

            while (sum > 9)
            {
                number = sum.ToString();
                sum = 0;
                foreach (char ch in number)
                {
                    sum += int.Parse((ch).ToString());
                }
            }
            Console.WriteLine(sum);
        }
    }
}
