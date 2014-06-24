using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRangeException
{
    class Program
    {
        static void Main()
        {
            try
            {
                CheckInt(1, 100);
                Console.Write("Enter date (year,month,date): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                CheckDate(date);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void CheckInt(int min,int max)
        {
           
            Console.Write("Enter number: ");
            int current = int.Parse(Console.ReadLine());
            if (current < min || current > max)
            {
                throw new InvalidRangeException<int>(min, max);
            }
            else
            {
                Console.WriteLine("Number is in range!");
            }
        }
        private static void CheckDate(DateTime date)
        {
            DateTime min = new DateTime(1980, 01,01);
            DateTime max = new DateTime(2013, 12, 31);
            if (date < min || date > max)
            {
                throw new InvalidRangeException<DateTime>(min, max);
            }
            else
            {
                Console.WriteLine("Date is in range!");
            }
        }
    }
}
