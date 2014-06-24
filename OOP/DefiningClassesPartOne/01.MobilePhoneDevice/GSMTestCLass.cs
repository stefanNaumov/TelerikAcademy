using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MobilePhoneDevice
{
    //Task 07 - test GSM Class
    public class GSMTestCLass
    {
        static void Main()
        {
            Console.Write("Enter number of phones: ");
            int numberOfPhones = int.Parse(Console.ReadLine());
            GSM[] arrayOfPhones = new GSM[numberOfPhones];
            int i = 0;
            // index i will leave one position at the end of the array for the IPhone
            for (; i < arrayOfPhones.Length-1; i++)
            {
                GSM currentPhone = new GSM();
                Console.Write("Enter phone {0} manifacturer: ", i + 1);
                currentPhone.Manifacturer = Console.ReadLine();
                Console.Write("Enter phone {0} model: ", i + 1);
                currentPhone.Model = Console.ReadLine();
                Console.Write("Enter the price of phone {0}: ", i + 1);
                currentPhone.Price = uint.Parse(Console.ReadLine());
                Console.Write("Enter phone {0} owner: ", i + 1);
                currentPhone.OwnerName = Console.ReadLine();
                
                arrayOfPhones[i] = currentPhone;
                
                Console.WriteLine();
            }
            //add the IPhone in the last position of the array
            arrayOfPhones[i] = GSM.IPhone;

            foreach (var phone in arrayOfPhones)
            {
                Console.WriteLine(phone.ToString()); //overrided ToStringMethod in GSM Class
                Console.WriteLine();
            }

            GSM gsmForTesting = new GSM();
            gsmForTesting.AddCallTohistory(new Call(DateTime.Now, 0888333444, 65));
            gsmForTesting.AddCallTohistory(new Call(DateTime.Now, 0888222444, 85));
            
            gsmForTesting.CalculateCallPrice();
            
            //Task 12
            gsmForTesting.DisplayCallInfo();
            gsmForTesting.RemoveLongestCallFromHistory();
            gsmForTesting.CalculateCallPrice();
            gsmForTesting.ClearCallHistory();
            gsmForTesting.DisplayCallInfo();
            
        }
    }
}
