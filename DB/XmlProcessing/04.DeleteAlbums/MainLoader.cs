using System;
using System.Collections.Generic;
using System.Xml;

//Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.

namespace DeleteAlbums
{
    class MainLoader
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../../catalogCopy.xml");

            XmlElement node = doc.DocumentElement;

            foreach (XmlNode child in node.ChildNodes)
            {
                double price = double.Parse(child["price"].InnerText.Trim());

                if (price > 5)
                {
                    child.ParentNode.RemoveChild(child);
                    Console.WriteLine("Removed {0}",child["name"].InnerText.Trim());
                }
            }

            doc.Save(@"../../../deletedAlbums.xml");
        }
    }
}
