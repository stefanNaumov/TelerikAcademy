using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedListLoader
    {
        //Must implement getting the previous element in the list in order to have correct removal of element

        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);

            list.Remove(6);
            ListItem<int> n = list.Find(7);
            while (n != null)
            {
                Console.WriteLine(n.Value);
                n = n.NextItem;
            }
        }
    }
}
