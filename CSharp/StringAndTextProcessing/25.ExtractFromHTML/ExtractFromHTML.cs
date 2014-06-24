using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
//Example:

//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skillful .NET software engineers.</p></body>
//</html>


class ExtractFromHTML
{
    static void Main()
    {
        string html = "<html>" + 
                            "<head><title>News</title></head>" +
                            "<body><p><a href=http://academy.telerik.com>Telerik" +
                                   "Academy</a>aims to provide free real-world practical " + 
                                    "training \n for young people who want to turn into " + 
                                    "skillful .NET software engineers.</p></body>" + 
                      "</html>";
        string title = ExtractTitle(html);
        Console.WriteLine(title);
    }
    static string ExtractTitle(string text)
    {
        Regex pattern = new Regex(@"(?<=^|>)[^><]+?(?=<|$)");
        StringBuilder builder = new StringBuilder();

        MatchCollection matches = pattern.Matches(text);

        foreach (var match in matches)
        {
            builder.Append(match +"\n");
        }
        return builder.ToString();
    }
}

