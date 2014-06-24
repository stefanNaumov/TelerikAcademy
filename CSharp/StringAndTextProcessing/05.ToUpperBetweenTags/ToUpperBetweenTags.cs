using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//You are given a text. 
//Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
//The tags cannot be nested. Example:

//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result:
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.



class ToUpperBetweenTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string toUpper = BetweenTagsToUpper(text);
        Console.WriteLine(toUpper);
    }
    static string BetweenTagsToUpper(string text)
    {
        text = Regex.Replace(text, @"\<upcase?>(.*?)</upcase?>", m => m.Groups[1].Value.ToUpper()); //lambda expression
        return text;
    }
}

