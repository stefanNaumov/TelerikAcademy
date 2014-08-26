using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement the ADT stack as auto-resizable array. 
//Resize the capacity on demand (when no space is available to add / insert a new element).
namespace Stack
{
    class StackLoader
    {
        static void Main(string[] args)
        {
            Stack<int> adtStack = new Stack<int>(3);

            for (int i = 0; i < 8; i++)
            {
                adtStack.Push(i);
            }
            Console.WriteLine(adtStack.Pop());
            Console.WriteLine(adtStack.Peek());
        }
    }
}
