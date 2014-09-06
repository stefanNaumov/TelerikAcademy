using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

//Implement the previous using XPath.

namespace ExtractARtistsXPath
{
    class MainLoader
    {
        static void Main()
        {
            Dictionary<string, int> allArtists = new Dictionary<string, int>();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../../catalog.xml");

            string artistsQuery = "/catalog/album/artist";

            XmlNodeList artists = doc.SelectNodes(artistsQuery);
            int index = 0;
            foreach (XmlNode artist in artists)
            {
                int albumsCount = artist.ChildNodes.Count;
                string artistName = artist.ChildNodes[0].Value.Trim();

                if (!allArtists.ContainsKey(artistName))
                {
                    allArtists.Add(artistName, albumsCount);
                }
                else
                {
                    allArtists[artistName] = albumsCount;
                }

                index++;
            }

            foreach (var artist in allArtists)
            {
                Console.WriteLine("{0} has {1} albums", artist.Key, artist.Value);
            }
        }
    }
}
