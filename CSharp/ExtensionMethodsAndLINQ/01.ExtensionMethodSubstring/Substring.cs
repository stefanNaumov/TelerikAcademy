using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSubstring
{
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder builder,int index,int length)
        {
            StringBuilder subBuilder = new StringBuilder();
            if (index < 0 || index >= builder.Length)
            {
                throw new IndexOutOfRangeException("Index outside bounds of the Stringbuilder!");
            }
            if (length < 1 || (index + length) >= builder.Length || length >= builder.Length)
            {
                throw new IndexOutOfRangeException("Length of the substring is outside the Stringbuilder bounds!");
            }
            for (int i = index; i <= length; i++)
            {
                subBuilder.Append(builder[i]);
            }
            return subBuilder;
        }
   
    }
}
