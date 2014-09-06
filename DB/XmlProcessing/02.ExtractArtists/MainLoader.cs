using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

//Write program that extracts all different artists which are found in the catalog.xml. 
//For each author you should print the number of albums in the catalogue. 
//Use the DOM parser and a hash-table.

namespace ExtractArtists
{
    class Program
    {
        static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../../catalog.xml");

            Dictionary<string, int> artists = new Dictionary<string, int>();
            XmlElement node = doc.DocumentElement;

            foreach (XmlElement child in node.ChildNodes)
            {
                string artist = child["artist"].InnerText.Trim();

                if (!artists.ContainsKey(artist))
                {
                    artists.Add(artist, 1);
                }

                foreach (var songs in child["songs"])
                {
                    artists[artist]++;
                }
            }

            foreach (var artist in artists)
            {
                Console.WriteLine("{0} has {1} songs",artist.Key, artist.Value);
            }
        }
    }
}
