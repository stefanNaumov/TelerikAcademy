using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpBrackets
{
    class CSharpBrackets
    {
        static List<string> unformattedInput = new List<string>();
        static List<string> formatted = new List<string>();
        static string indentationSymbol;
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            indentationSymbol = Console.ReadLine();
            
            for (int i = 0; i < N; i++)
            {
                unformattedInput.Add(Console.ReadLine());
            }
            FormatCode();
            for (int i = 0; i < formatted.Count; i++)
            {
                Console.WriteLine(formatted[i]);
            }
            Console.WriteLine();
        }
        static string Trim(string line)
        {
            return Regex.Replace(line.Trim(), " +"," ");
        }
        static string AddTabulation(string symbol, int tabulationLevel)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < tabulationLevel; i++)
            {
                builder.Append(indentationSymbol);
            }
            builder.Append(symbol);

            return builder.ToString();
        }
        static void FormatCode()
        {
            int tabLevel = 0;

            foreach (string line in unformattedInput)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '{')
                    {
                        formatted.Add(AddTabulation("{", tabLevel++));
                    }
                    else if (line[i] == '}')
                    {
                        formatted.Add(AddTabulation("}", --tabLevel)); //!!!
                    }
                    else
                    {
                        StringBuilder addCode = new StringBuilder();

                        while (i < line.Length  && line[i] != '{' && line[i] != '}')
                        {
                            addCode.Append(line[i++]);
                            
                        }
                        i--;
                        
                        string format = addCode.ToString();

                        if (!String.IsNullOrWhiteSpace(format))
                        {
                            formatted.Add(AddTabulation(Trim(format),tabLevel)); 
                        }
                        
                    }
                    
                }
            }
        }
    }
}
