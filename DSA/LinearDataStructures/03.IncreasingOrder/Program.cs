using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order.

class Program
{
    static void Main()
    {
        List<int> sequence = ReadInput();
        sequence.Sort();
        for (int i = 0; i < sequence.Count; i++)
        {
            Console.Write(sequence[i] + " ");
        }
        Console.WriteLine();
    }
    static List<int> ReadInput()
    {
        List<int> list = new List<int>();
        string line = Console.ReadLine();
        while(!(String.IsNullOrEmpty(line)))
        {
            list.Add(int.Parse(line));
            line = Console.ReadLine();
        }
        return list;
    }
}

