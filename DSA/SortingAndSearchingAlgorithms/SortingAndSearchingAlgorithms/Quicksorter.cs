namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection is null!");
            }

            if (collection.Count <= 1)
            {
                return;
            }

            collection = this.QuickSort(collection);
        }
        public IList<T> QuickSort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }
            IList<T> less = new List<T>();
            IList<T> greater = new List<T>();
            T pivot = GeneratePivot(collection);
            int pivotIndex = collection.IndexOf(pivot);

            for (int i = 0; i < collection.Count; i++)
            {
                if (i == pivotIndex)
                {
                    continue;
                }
                if (collection[i].CompareTo(pivot) <= 0)
                {
                    less.Add(collection[i]);
                }
                else
                {
                    greater.Add(collection[i]);
                }
                
            }
            return Concatenate(QuickSort(less), pivot, QuickSort(greater));
        }
        public T GeneratePivot(IList<T> collection)
        {
            T firstElement = collection[0];
            T lastElement = collection[collection.Count - 1];
            T middleElement = collection[collection.Count / 2];
            T[] array = new T[] { firstElement, middleElement, lastElement };
            Array.Sort(array);
            return array[1];
        }
        public IList<T> Concatenate(IList<T> less, T pivot, IList<T> greater)
        {
            List<T> concatenated = new List<T>();
            concatenated.AddRange(less);
            concatenated.Add(pivot);
            concatenated.AddRange(greater);

            return concatenated;
        }
    }
}