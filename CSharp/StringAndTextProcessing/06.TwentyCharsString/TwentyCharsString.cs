using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TwentyCharsString
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        if (text.Length > 20)
        {
            throw new IndexOutOfRangeException("\n string length must be less or equal to 20!");
        }
        else
        {
            string withAsteriks = AddAsteriks(text);
            Console.WriteLine(withAsteriks);
        }
    }
    static string AddAsteriks(string text)
    {
        StringBuilder builder = new StringBuilder(text);
        while (builder.Length < 20)
        {
            builder.Append('*');
        }
        return text = builder.ToString();
    }
}

