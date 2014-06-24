using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.QuickSort
{
    class QuickSorter<T> where T: IComparable<T>
    {
        private IList<T> collection;
        public QuickSorter(IList<T> collection)
        {
            this.collection = QuickSortInPlace(collection, 0, collection.Count - 1);
        }
        //Stable implementation!!!
        private static List<T> Sort(List<T> collection)
        {
            if (collection.Count <= 1)
            {
                return collection;
            }
            List<T> less = new List<T>();
            List<T> greater = new List<T>();
            //TODO: implement optimized pivot selection
            //T pivot = GetPivot(collection);
            T pivot = collection[collection.Count / 2];
            collection.RemoveAt(collection.IndexOf(pivot));
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].CompareTo(pivot) <= 0)
                {
                    less.Add(collection[i]);
                }
                else if (collection[i].CompareTo(pivot) > 0)
                {
                    greater.Add(collection[i]);
                }
            }
            Sort(less);
            Sort(greater);
            collection.Clear();
            collection.AddRange(less);
            collection.Add(pivot);
            collection.AddRange(greater);
            return collection;
        }
        //Not Stable implementation!!!
        private static IList<T> QuickSortInPlace(IList<T> collection, int left, int right)
        {
            int i = left;
            int j = right;
            T pivot = collection[(left + right) / 2];

            while (i <= j)
            {
                while (collection[i].CompareTo(pivot) < 0 )
                {
                    i++;
                }
                while (collection[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    T temp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                QuickSortInPlace(collection, left, j);
            }
            if (right > i)
            {
                QuickSortInPlace(collection, i, right);
            }
            return collection;
        }
        private static T GetPivot(List<T> collection)
        {
            //Random generator = new Random();
            //T pivot = collection[generator.Next(0, collection.Count - 1)];
            //return pivot;
            T start = collection[0];
            T middle = collection[collection.Count / 2];
            T end = collection[collection.Count - 1];

            if (start.CompareTo(middle) > 0 && start.CompareTo(end) > 0)
            {
                return end;
            }
            else if (middle.CompareTo(start) > 0 && middle.CompareTo(end) > 0)
            {
                return start;
            }
            else if (end.CompareTo(start) > 0 && end.CompareTo(middle) > 0)
            {
                return middle;
            }
            else
            {
                return middle;
            }
            
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
