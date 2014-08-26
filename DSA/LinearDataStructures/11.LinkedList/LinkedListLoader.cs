using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedListLoader
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);

            ListItem<int> n = list.Find(6);
            Console.WriteLine(n.Value);
        }
    }
}
