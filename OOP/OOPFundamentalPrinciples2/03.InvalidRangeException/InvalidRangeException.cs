using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRangeException
{
    public class InvalidRangeException<T>: ArgumentException
        where T: IComparable,IComparable<T>
    {
        private T min;
        private T max;
        

        public InvalidRangeException(T min, T max)
        {
            this.min = min;
            this.max = max;
            
        }
        public T Min
        {
            get { return this.min; }
        }
        public T Max
        {
            get { return this.max; }
        }
        public override string Message
        {
            get
            {
                return "Value must be in the range: " + min + "->" + max;
            }
        }
    }
}
