using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
//Hi!
//Expected output:
//\u0048\u0069\u0021



class StringToUnicode
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();
        string unicodeLiterals = StringConvertToUnicode(text);
        Console.WriteLine(unicodeLiterals);
    }
    static string StringConvertToUnicode(string text)
    {
        StringBuilder builder = new StringBuilder();

        foreach (char c in text)
        {
            builder.AppendFormat("\\u{0:x4}", (int)c);
        }
        return builder.ToString();
    }
}

