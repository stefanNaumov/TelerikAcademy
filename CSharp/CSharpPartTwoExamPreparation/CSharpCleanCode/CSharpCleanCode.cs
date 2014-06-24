using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class CSharpCleanCode
{
    static bool isQuoted = false;
    static bool isLongComment = false;

    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        
        string[] cleaned = new string[numberOfLines];
        string[] lines = new string[numberOfLines];
        for (int i = 0; i < numberOfLines; i++)
        {
            lines[i] = Console.ReadLine();
        }

        for (int i = 0; i < numberOfLines; i++)
        {
            cleaned[i] = ProcessLine(lines[i]);
            if (isLongComment == true)
            {
                int start = i;
                while (isLongComment == true)
                {
                    cleaned[i] += ProcessLine(lines[start]);
                    start++;
                }
                i = start - 1;
            }
            
        }
        var edited = cleaned.Where(arg => !string.IsNullOrWhiteSpace(arg));
        foreach (var item in edited)
        {
            Console.WriteLine(item);
        }
        
        //for (int i = 0; i < cleaned.Length; i++)
        //{
        //    cleaned[i].Replace(Environment.NewLine, String.Empty);
        //    Console.WriteLine(cleaned[i]);
        //}
    }

    private static string ProcessLine(string currentLine)
    {
        StringBuilder cleanCode = new StringBuilder();
        

        for (int i = 0; i < currentLine.Length; i++)
        {
            if(isQuoted == true)
            {
                while (i < currentLine.Length && currentLine[i] != '"')
                {
                    cleanCode.Append(currentLine[i]);
                    i++;
                    if (i < currentLine.Length-1 && currentLine[i] == '"')          //!!!
                    {
                        if (currentLine[i + 1] == ';')
                        {
                            cleanCode.Append(currentLine[i] + currentLine[i + 1]); // !+!!!
                        }
                        else
                        {
                            cleanCode.Append(currentLine[i]);
                        }
                        isQuoted = false;
                    }
                    
                }
            }
            else if (isLongComment == true)
            {
                int indexOfLongComment = currentLine.IndexOf("*/");

                if (indexOfLongComment == -1)
                {
                    break;
                }
                else
                {
                    i = indexOfLongComment + 1;
                    isLongComment = false;
                }
            }
            else if(currentLine[i] == '/')
            {
                if (i + 1 < currentLine.Length && currentLine[i + 1] == '/')
                {
                    break;
                }
                else if (i + 1 < currentLine.Length && currentLine[i + 1] == '*')
                {
                    isLongComment = true;
                    
                }
                else
                {
                    cleanCode.Append(currentLine[i]);
                }
            }
            else
            {
                cleanCode.Append(currentLine[i]);
            }
        }
        return cleanCode.ToString();

    }
    
}

