using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace TeamWorkTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string phone = "088833355566";
            ulong number = RegexCheckName.CheckNumber(phone);
            Console.WriteLine(number);
        }
    }
    public class Client
    {
        public int ClientNumber { get; private set; }
        public Client()
        {
            
        }
        
        public void SaveClientNumber(int clientNumber)
        {
            StreamWriter writer = new StreamWriter(@"..\..\ClientNumbers.txt", true);
            StringBuilder client = new StringBuilder();
            client.AppendFormat("{0} ", clientNumber);
            using (writer)
            {
                writer.WriteLine(client.ToString()); 
            }
        }
    }

    public class Truck
    {
        public string[] currentRoute { get; set; }
        public Truck(Routes route)
        {
            Route r = new Route();
            currentRoute = r.GetRoute(route);
        }
    }
    public static class RegexCheckName
    {
        public static bool CheckName(string name)
        {
            if (!Regex.Match(name, @"^[a-zA-Z][a-zA-Z0-9}\._\-]{0,20}?[a-zA-Z0-9]{0,2}$").Success)
            {
                
            }
            return true;
        }

        public static ulong CheckNumber(string number)
        {
            string[] arr = number.Split(new string[] { ".", "-", " " }, StringSplitOptions.RemoveEmptyEntries);
            string splitted = ValidateNumber(arr);
            if (splitted.Length > 10 || splitted.Length < 10)
            {
                return 0;
            }
            return ulong.Parse(splitted);
        }

        public static string ValidateNumber(string[] splittedString)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < splittedString.Length; i++)
            {
                builder.Append(splittedString[i]);
            }
            return builder.ToString();
        }
    }

}
