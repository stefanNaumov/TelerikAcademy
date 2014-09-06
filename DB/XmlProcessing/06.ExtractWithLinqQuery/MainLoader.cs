using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

//Rewrite the previous task using XDocument and LINQ query.

namespace ExtractWithLinqQuery
{
    class MainLoader
    {
        static void Main()
        {
            XDocument doc = XDocument.Load(@"../../../catalog.xml");

            var songs = from s in doc.Descendants("song")
                        select s.Value;

            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }

        }
    }
}
