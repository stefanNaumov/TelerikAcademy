using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MergeSort
{
    class MergeSorter<T> where T: IComparable<T>
    {
        private IList<T> collection;
        public MergeSorter(IList<T> collection)
        {
            this.collection = MergeSort(collection);
        }
        private static IList<T> MergeSort(IList<T> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }
            IList<T> left = new List<T>();
            IList<T> right = new List<T>();
            int middle = collection.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(collection[i]);
            }
            for (int i = middle; i < collection.Count; i++)
            {
                right.Add(collection[i]);
            }
            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }
        private static IList<T> Merge(IList<T> left, IList<T> right)
        {
            IList<T> merged = new List<T>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left[0].CompareTo(right[0]) <= 0)
                    {
                        merged.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        merged.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    merged.Add(left[0]);
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    merged.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            return merged;
        }
        public T this[int index]
        {
            get { return this.collection[index]; }
        }
        public int Count
        {
            get { return this.collection.Count; }
        }
    }
}
