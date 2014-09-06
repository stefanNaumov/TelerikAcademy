using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

//Write a program, which using XmlReader extracts all song titles from catalog.xml.

namespace ExtractWithXmlReader
{
    class MainLoader
    {
        static void Main()
        {

            XmlReader reader = XmlReader.Create("../../../catalog.xml");
            List<string> songs = new List<string>();

            using (reader)
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                    {
                        songs.Add(reader.ReadElementContentAsString());
                    }
                }
            }

            Console.WriteLine(String.Join(", ",songs));
        }
    }
}
