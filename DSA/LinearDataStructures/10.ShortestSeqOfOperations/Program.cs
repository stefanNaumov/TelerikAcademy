using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* We are given numbers N and M and the following operations:
//N = N+1
//N = N+2
//N = N*2
//Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M. Hint: use a queue.
//Example: N = 5, M = 16
//Sequence: 5  7  8  16

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M:");
        int M = int.Parse(Console.ReadLine());

        List<int> sequence = FindSequence(N, M);
        for (int i = 0; i < sequence.Count; i++)
        {
            Console.Write(sequence[i] + " ");
        }
        Console.WriteLine();
    }
    static List<int> FindSequence(int N,int M)
    {
        Stack<int> queue = new Stack<int>();
        while (M / 2 >= N)
        {
            M /= 2;
            queue.Push(M);
        }
        while (M - 2 >= N)
        {
            M -= 2;
            queue.Push(M);
        }
        while (M - 1 >= N)
        {
            M -= 1;
            queue.Push(M);
        }
        
        return queue.ToList();
    }
}

