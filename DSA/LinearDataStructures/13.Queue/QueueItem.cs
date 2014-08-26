using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueItem<T> where T: IComparable<T>
    {
        public T Value { get; set; }
        public QueueItem<T> NextItem { get; set; }

        public QueueItem()
        {
            
        }

        public int CompareTo(T obj)
        {
            return this.Value.CompareTo(obj);
        }
    }
}
