using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.



class ExtractEmailAdresses
{
    static void Main()
    {
        string text = "Please contact us by phone (+359 222 222 12 ) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk.";
                      
        string mails = ExtractEmails(text);
        Console.WriteLine(mails);
    }
    static string ExtractEmails(string text)
    {
        Regex pattern = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\{2,5})*");
        MatchCollection mails = pattern.Matches(text);
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < mails.Count; i++)
        {
            builder.Append(mails[i].Value + "\n");
        }
        return builder.ToString();
    }
}

