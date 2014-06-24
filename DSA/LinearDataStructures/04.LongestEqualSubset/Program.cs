using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that finds the longest subsequence of equal numbers in given List<int> 
//and returns the result as new List<int>. Write a program to test whether the method works correctly.

class Program
{
    static void Main()
    {
        List<int> sequence = ReadInput();
        List<int> subset = LongestEqualSubseq(sequence);
        Console.WriteLine("Longest equal subsequence is: ");
        for (int i = 0; i < subset.Count; i++)
        {
            Console.Write(subset[i] + " ");
        }
        Console.WriteLine();
    }

    static List<int> ReadInput()
    {
        List<int> sequence = new List<int>();
        string[] input = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < input.Length; i++)
        {
            sequence.Add(int.Parse(input[i]));
        }
        return sequence;
    }

    static List<int> LongestEqualSubseq(List<int> sequence)
    {
        List<int> subseqList = new List<int>();
        List<int> tempList = new List<int>();
        if (sequence.Count == 0 || sequence.Count == 1)
        {
            return sequence;
        }
        for (int i = 0; i < sequence.Count - 1; i++)
        {
            int tempCounter = 1;
            while (sequence[i] == sequence[i + 1])
            {
                tempCounter++;
                tempList.Add(sequence[i]);
                tempList.Add(sequence[i + 1]);
                i++;
            }
            if (tempCounter > subseqList.Count)
            {
                subseqList = tempList;
                tempList.Clear();
            }
        }
        return subseqList;
    }
}

