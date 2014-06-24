using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FTML
{
    public const string RevTagOpen = "<rev>";
    public const string UpperTagOpen = "<upper>";
    public const string LowerTagOpen = "<lower>";
    public const string ToggleTagOpen = "<toggle>";
    public const string DeleteTagOpen = "<del>";

    public const string RevTagClosed = "</rev>";
    public const string UpperTagClosed = "</upper>";
    public const string LowerTagClosed = "</lower>";
    public const string ToggleTagClosed = "</toggle>";
    public const string DeleteTagClosed = "</del>";
    private static StringBuilder output = new StringBuilder();
    private static int openDelTag = 0;

    private static List<string> currentOpenTags = new List<string>();
    private static List<int> revTagsStart = new List<int>();
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfLines; i++)
        {
            string currentLine = Console.ReadLine();
            ProccessLine(currentLine);
        }
    }
    static void ProccessLine(string line)
    {
        for (int i = 0; i < line.Length; i++)
        {
            string currentLine = Console.ReadLine();
            int currentSymbolIndex = 0;

            while (currentSymbolIndex < currentLine.Length)
            {
                if (currentLine[currentSymbolIndex] == '<')
                {
                    string tag = GetTag(currentLine,currentSymbolIndex);
                    ProccessTag(tag);

                    currentSymbolIndex += tag.Length - 1;
                }
                else
                {
                    if (openDelTag == 0)
                    {
                        char symbolToAdd = currentLine[currentSymbolIndex];
                        for (int j = currentOpenTags.Count - 1; j >= 0; j--)
                        {
                           //symbolToAdd = ApplayEffects(symbolToAdd,currentOpenTags[j]);
                        }
                        output.Append(symbolToAdd);
                    }
                }
                currentSymbolIndex++;
            }
            output.AppendLine();
        }
    }
    //static char ApplayEffects(char symbolToAdd, string currentOpenTag)
    //{
        
    //}
    private static void ProccessTag(string tag)
    {
        if (tag == DeleteTagOpen)
        {
            openDelTag++;
        }
        else if (tag == DeleteTagClosed)
        {
            openDelTag--;
        }
        else
        {
            if (openDelTag == 0)
            {
                if (tag == RevTagOpen)
                {
                    revTagsStart.Add(output.Length);
                }
                else if (tag == RevTagClosed)
                {
                    int currentRevStart = revTagsStart[revTagsStart.Count - 1];
                    int revEnd = output.Length - 1;
                    Reverse(currentRevStart, revEnd);
                }
                else if (tag[1] == '/')
                {
                    currentOpenTags.RemoveAt(currentOpenTags.Count - 1); //we need only the opening tags
                }
                else
                {
                    currentOpenTags.Add(tag);
                }
            }
        }
    }

    private static void Reverse(int revStart,int revEnd)
    {
        int start = revStart;
        int end = revEnd;

        while (start < end)
        {
            char bufferChar = output[start];
            output[start] = output[end];
            output[end] = bufferChar;
            end--;
            start++;
        }
    }

    private static string GetTag(string line, int symbolIndex)
    {
        int startIndex = symbolIndex;
        int tagEnd = line.IndexOf('>', startIndex + 1);
        string tag = line.Substring(startIndex, tagEnd - startIndex + 1);

        return tag;
    }
}

