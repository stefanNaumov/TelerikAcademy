using System;

namespace _12.AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            int ageAfter = (int.Parse(age)) + 10;
            Console.WriteLine("After ten years you will be {0}",ageAfter);
            
        }
    }
}
