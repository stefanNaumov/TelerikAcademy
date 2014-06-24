using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static List<string> justified = new List<string>();

    static int numberOfSymbols;

    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        numberOfSymbols = int.Parse(Console.ReadLine());
        string text = ReadInput(numberOfLines);
        FormatText(text, numberOfSymbols);
    }
    static string ReadInput(int numberOfLines)
    {
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < numberOfLines; i++)
        {
            string currentLine = Console.ReadLine();
            builder.AppendLine(currentLine);

        }
        return builder.ToString();
    }
    static void FormatText(string text, int numberOfSymbols)
    {
        StringBuilder currentLine = new StringBuilder();
        StringBuilder formattedText = new StringBuilder();
        string[] splitted = text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        int charPosition = 0;
        while (true)
        {
            int symbolCounter = 0;
            while (symbolCounter <= numberOfSymbols)
            {
                if (charPosition < splitted.Length)
                {
                    currentLine.Append(splitted[charPosition] + " ");

                    symbolCounter = currentLine.Length;
                    charPosition++;
                    if (charPosition < splitted.Length && symbolCounter + splitted[charPosition].Length >= numberOfSymbols)
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            formattedText.AppendLine(currentLine.ToString());
            currentLine.Clear();
        }
    }
}




