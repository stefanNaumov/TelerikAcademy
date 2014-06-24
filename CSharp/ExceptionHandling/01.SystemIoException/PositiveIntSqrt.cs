using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveIntSqrt
{
    class NumSqrt
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter number: ");
                string number = Console.ReadLine();
                int num = Int32.Parse(number);
                CheckIfNegative(num);
                int result = num * num;
                Console.WriteLine("Parsing succesfull, result is {0} ",result);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Number is not in a valid format!" + fe.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
            
        }
        static void CheckIfNegative(int num)
        {
            if (num < 0)
            {
                throw new ArgumentOutOfRangeException("The number must be positive!");
            }
        }
        
    }
}
