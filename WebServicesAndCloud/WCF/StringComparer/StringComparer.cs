using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace StringComparer
{
    [DataContract]
    public class StringComparerService : IStringComparer
    {
        public int NumberOfOccurences(string first, string second)
        {
            int index = 0;
            int counter = 0;

            while (first.IndexOf(second,index) != -1)
            {
                counter++;
                index = index + second.Length - 1;
            }

            return counter;
        }
    }
}
