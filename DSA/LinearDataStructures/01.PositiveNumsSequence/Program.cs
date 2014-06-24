using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a sequence of positive integer numbers. 
//The sequence ends when empty line is entered. 
//Calculate and print the sum and average of the elements of the sequence. 
//Keep the sequence in List<int>.

class Program
{
    static void Main()
    {
        List<int> list = ReadData();
        int sum = CalculateSum(list);
        int average = CalculateAverage(list);
        Console.WriteLine("The sum of the sequence is: {0}",sum);
        Console.WriteLine("The average of the sequence is: {0}",average);
    }
    static List<int> ReadData()
    {
        string line = Console.ReadLine();
        List<int> numbers = new List<int>(); 
        while(!(String.IsNullOrEmpty(line)))
        {
            if (int.Parse(line) < 0)
            {
                throw new ArgumentException("Input must be a positive integer!");
            }
            numbers.Add(int.Parse(line));
            line = Console.ReadLine();
        }
        return numbers;
    }
    static int CalculateSum(List<int> sequence)
    {
        int sum = 0;
        for (int i = 0; i < sequence.Count; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }
    static int CalculateAverage(List<int> sequence)
    {
        int sum = CalculateSum(sequence);
        int average = sum / sequence.Count;
        return average;
    }
}

