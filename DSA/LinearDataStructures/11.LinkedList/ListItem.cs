using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class ListItem<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public ListItem<T> NextItem { get; set; }

        public ListItem()
        {
            
        }

        public int CompareTo(T obj)
        {
            return this.Value.CompareTo(obj);
        }
    }
}
