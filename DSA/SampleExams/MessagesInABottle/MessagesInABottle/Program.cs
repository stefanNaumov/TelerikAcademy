using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagesInABottle
{
    class Program
    {
        static Dictionary<char, string> cipherValues = new Dictionary<char, string>();
        static List<string> messageCombs = new List<string>();
        static char[] currCombination = new char[60];

        static void Main()
        {
            string message = Console.ReadLine();

            string cipher = Console.ReadLine();

            ParseCipher(cipher);

            CountMessageCombs(message, 0, 0);

            Console.WriteLine(messageCombs.Count);

            messageCombs.Sort();

            for (int i = 0; i < messageCombs.Count; i++)
            {
                var currStr = messageCombs[i];

                for (int j = 0; j < currStr.Length; j++)
                {
                    Console.Write(currStr[j]);
                }
                Console.WriteLine();
            }
            

        }

        static void ParseCipher(string cipher)
        {
            int index = 0;
            char currLetter;
            StringBuilder currValue = new StringBuilder();

            while (index < cipher.Length)
            {
                if (cipher[index] >= 'A' && cipher[index] <= 'Z')
                {
                    currLetter = cipher[index];
                    index++;

                    while (index < cipher.Length && !(cipher[index] >= 'A' && cipher[index] <= 'Z'))
                    {
                        currValue.Append(cipher[index]);
                        index++;
                    }

                    cipherValues.Add(currLetter, currValue.ToString());
                    currValue.Clear();
                }    
            }
        }

        static void CountMessageCombs(string message, int index, int combinationIndex)
        {
            if (index == message.Length)
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < currCombination.Length; i++)
                {
                    builder.Append(currCombination[i]);
                }
                messageCombs.Add(builder.ToString());

                return;
            }
            if (index > message.Length)
            {
                return;
            }

            foreach (var item in cipherValues)
            {
                if (item.Value.Length + index <= message.Length && message.Substring(index,item.Value.Length) == item.Value)
                {
                    currCombination[combinationIndex] = item.Key;
                    CountMessageCombs(message, index + item.Value.Length, combinationIndex + 1);
                    currCombination[combinationIndex] = char.MinValue;
                }
            }
        }
    }
}
