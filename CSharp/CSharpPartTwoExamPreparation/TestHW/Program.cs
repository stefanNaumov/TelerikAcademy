using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace zad15HTML
{
    class HTML
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"D:\Test.txt");
            using (reader)
            {
                string line = string.Empty;
                MatchCollection matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
                while ((line = reader.ReadLine()) != null)
                {
                    matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");

                    foreach (var word in matchProtocolAndSiteName)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}
