using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that removes from given sequence all negative numbers.

class Program
{
    static void Main()
    {
        int[] sequence = ReadInput();
        List<int> positiveNums = RemoveNegativeIntegers(sequence);

        foreach (var item in positiveNums)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    static int[] ReadInput()
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] sequence = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            sequence[i] = int.Parse(input[i]);
        }
        return sequence;
    }
    static List<int> RemoveNegativeIntegers(int[] sequence)
    {
        List<int> positiveNumsList = new List<int>();
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] >= 0)
            {
                positiveNumsList.Add(sequence[i]);
            }
        }
        return positiveNumsList;
    }
}

