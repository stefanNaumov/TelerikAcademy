using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtMethods
{
    public static class IEnExtensionMethods
    {
        public static T Sum<T>(this IEnumerable<T> list)
            where T: IComparable
        {
            dynamic sum = 0;
            foreach (T item in list)
            {
                sum += item;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> list)
        where T: IComparable
        {
            dynamic product = 1;
            foreach (T item in list)
            {
                product *= item;
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> list)
        where T: IComparable
        {
            dynamic min = 2000000000000000000;
            foreach (T item in list)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> list)
        where T: IComparable
        {
            dynamic max = -2000000000000000000;
            foreach (T item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T Average<T>(this IEnumerable<T> list)
        where T: IComparable
        {
            dynamic sum = 0;
            int counter = 1;
            foreach (T item in list)
            {
                sum += item;
                counter++;
            }
            
            dynamic average = sum / counter;
            return average;
        }
    }
}
