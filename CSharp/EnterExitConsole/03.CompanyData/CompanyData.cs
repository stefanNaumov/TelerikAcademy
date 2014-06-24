using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints them on the console.


namespace _03.CompanyData
{
    class CompanyData
    {
        static void Main()
        {
            Console.WriteLine("Enter name of the company:");
            string company = Console.ReadLine();
            Console.WriteLine("Enter address of the company:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter phone number of the company:");
            string  Phone = Console.ReadLine();
            Console.WriteLine("Enter fax number of the company:");
            string Fax = Console.ReadLine();
            Console.WriteLine("Enter web address of the company:");
            string webSite = Console.ReadLine();
            Console.WriteLine("Enter manager's first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter manager's last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter manager's age:");
            string age = Console.ReadLine();
            Console.WriteLine("Enter manager's phone number:");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();
           
            Console.WriteLine("Company: {0} \nAddress: {1} \nPhone number: {2} FAX: {3} \nweb site: {4}",
                company, address, Phone, Fax, webSite);
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Manager: {0} {1} - {2} age \nPhone number: {3}",
                firstName, lastName, age, managerPhone);
            Console.WriteLine(new string('*', 30));

        }
    }
}
