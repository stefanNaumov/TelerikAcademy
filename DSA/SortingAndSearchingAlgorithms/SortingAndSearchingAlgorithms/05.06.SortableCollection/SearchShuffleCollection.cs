using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortableCollection
{
    public class SearchShuffleCollection<T> where T: IComparable<T>
    {
        private IList<T> collection;

        public SearchShuffleCollection(IList<T> collection)
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

        //shuffle using Fisher Yates algorithm
        public IList<T> Shuffle()
        {
            int index = this.collection.Count - 1;
            Random generator = new Random();

            while (index > 1)
            {
                int rand = generator.Next(1, index);

                T tmp = this.collection[rand];
                this.collection[rand] = this.collection[index];
                this.collection[index] = tmp;

                index--;
            }

            return this.collection;
        }
    }
}
