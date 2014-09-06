using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

//In a text file we are given the name, address and phone number of given person (each at a single line).
//Write a program, which creates new XML document, which contains these data in structured XML format
namespace CreateXmlFile
{
    class MainLoader
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"../../../PersonData.txt");
            XElement persons = new XElement("persons");
            int counter = 0;
             
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (counter % 3 == 0)
                    {
                        string name = line;
                        persons.Add(new XElement("person"),
                            new XElement("name", name));

                    }

                    if (counter % 3 == 1)
                    {
                        string address = line;
                        persons.Add(new XElement("address", address));
                    }

                    if (counter % 3 == 2)
                    {
                        string phone = line;
                        persons.Add(new XElement("phone", phone));
                    }
                    counter++;
                    line = reader.ReadLine();
                }
                
            }
            
            persons.Save("@../../../../../People.xml");
            Console.WriteLine("Data saved in People.xml");
        }
        
    }
}
