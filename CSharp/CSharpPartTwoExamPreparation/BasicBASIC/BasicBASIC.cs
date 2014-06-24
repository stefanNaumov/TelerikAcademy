using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class BasicBASIC
{
    static Dictionary<int, string> codeLines = new Dictionary<int, string>();
    static int V,W,X,Y,Z;
    static int codePosition = 0;
    static void Main()
    {
        ReadInputCode();

        while (true)
        {
            string currentLine = codeLines[codePosition];
            //ProccessLine(currentLine);
        }
    }
    
    static void ReadInputCode()
    {
        int counter = 0;
        while (true)
        {
            string currentLine = Console.ReadLine();

            if (currentLine != "RUN")
            {
                string[] lineAndCode = currentLine.Split(new char[] { ' ' }, 2,StringSplitOptions.RemoveEmptyEntries);
                codeLines.Add(int.Parse(lineAndCode[0]), lineAndCode[1]);
                if (counter < 1)
                {
                    codePosition = int.Parse(lineAndCode[0]);
                }
                counter++;
            }
            else
            {
                break;
            }
            //Match lineValue = Regex.Match(currentLine, "[0-9]{1,5}");
            //codeLines.Add(int.Parse(lineValue.Value.ToString()), currentLine);
        }
    }
}

