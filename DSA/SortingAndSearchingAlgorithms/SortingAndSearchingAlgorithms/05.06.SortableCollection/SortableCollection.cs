using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortableCollection
{
    public class SortableCollection<T> where T: IComparable<T>
    {
        private IList<T> collection;

        public SortableCollection(IList<T> collection)
        {
            this.collection = collection;
        }

        public T BinarySearch(T target) 
        {
            int start = 0;
            int end = this.collection.Count - 1;

            while (start <= end)
            {
                int midIndex = (start + end) / 2;
                T middle = this.collection[midIndex];

                if (target.CompareTo(middle) > 0)
                {
                    start = midIndex + 1;
                }
                else if (target.CompareTo(middle) < 0)
                {
                    end = midIndex - 1;
                }
                else
                {
                    return middle;
                }
            }

            return default(T);
        }
    }
}
