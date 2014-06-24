using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            stack.Push(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}

