using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesInABottle
{
    class Program
    {
        static Dictionary<char, string> letters;
        static List<string> messages;
        static char[] currMessage;
        static int codeLength;

        static void Main()
        {
            letters = new Dictionary<char, string>();
            
            string code = Console.ReadLine().Trim();
            codeLength = code.Length;
            messages = new List<string>();
            currMessage = new char[50];

            string cipher = Console.ReadLine().Trim();
            ParseInput(cipher);

            GenMessages(0, 0, code);

            messages.Sort();

            Console.WriteLine(messages.Count);
            Print();

            Console.WriteLine();
        }

        static void GenMessages(int index, int combinationIndex, string code)
        {
            if (index >= codeLength)
            {
                StringBuilder messageBuilder = new StringBuilder();
                for (int i = 0; i < currMessage.Length; i++)
                {
                    if (!char.IsLetter(currMessage[i]))
                    {
                        break;
                    }
                    messageBuilder.Append(currMessage[i]);
                }
                messages.Add(messageBuilder.ToString() + "\n");
                return;
            }

            foreach (var letter in letters)
            {
                if (letter.Value.Length + index <= codeLength && code.Substring(index, letter.Value.Length) == letter.Value)
                {
                    currMessage[combinationIndex] = letter.Key;
                    GenMessages(index + letter.Value.Length, combinationIndex + 1, code);
                    currMessage[combinationIndex] = char.MinValue;
                }
            }
        }

        static void Print()
        {
            for (int i = 0; i < messages.Count; i++)
            {
                Console.Write(messages[i]);
            }
        }

        static void ParseInput(string cipher)
        {
            string currNumber;
            char key = char.MinValue;
            StringBuilder codeBuilder = new StringBuilder();

            for (int i = 0; i < cipher.Length; i++)
            {
                if (char.IsLetter(cipher[i]))
                {
                    if (codeBuilder.Length > 0)
                    {
                        currNumber = codeBuilder.ToString();
                        letters.Add(key, currNumber);
                        codeBuilder.Clear();
                    }

                    key = cipher[i];
                }
                else
                {
                    codeBuilder.Append(cipher[i]);
                }

                if (i == cipher.Length - 1)
                {
                    letters.Add(key, codeBuilder.ToString());
                }
            }
        }
    }
}
