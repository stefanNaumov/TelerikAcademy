using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int numberOfElements = int.Parse(Console.ReadLine());

        string[] numbersArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbersToIntArr = new int[numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            numbersToIntArr[i] = int.Parse(numbersArray[i]);
        }
        string result = GenerateSequence(numbersToIntArr);
        Console.WriteLine(result);
    }

    static string GenerateSequence(int[] elements)
    {
        StringBuilder builder = new StringBuilder();
        
        bool[] checkForCycle = new bool[elements.Length];
        
        bool hasFoundCycle = false;
        int index = 0;
        int loopStartIndex = -1;

        while (true)
        {
            
            if(index > elements.Length || index < 0)
            {
                //builder.Remove(builder.Length - 2, 1);
                break;
            }
            if(checkForCycle[index] == true)
            {
                loopStartIndex = index; 
                hasFoundCycle = true;
                break;
            }
            builder.Append(index);
            builder.Append(" ");
            checkForCycle[index] = true;
            index = elements[index];
        }
        if (hasFoundCycle == true)
        {

            if (loopStartIndex >= 0)
            {
                int bracketIndex = builder.ToString().IndexOf(" " + loopStartIndex.ToString() + " ");
                //builder.Replace(" ", "", loopStartIndex, 1);
                //builder.Insert(loopStartIndex * 2 - 1, "(");
                //builder.Insert(builder.Length - 1, ")");
                if(bracketIndex < 0)
                {
                    builder.Insert(0, "(");
                }
                else
                {
                    builder[bracketIndex] = '('; 
                }
                //builder.Replace(" ", "", bracketIndex - 1, 1);
                builder[builder.Length - 1] = ')'; 
                
            }
            //builder[loopStartIndex * 2 - 1] = '(';
            //builder[builder.Length-1] = ')';
        }
        
        return builder.ToString().Trim();
    }
}

