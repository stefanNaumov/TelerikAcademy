using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belot.Common
{
    public class CheckBitAtPosition
    {
        private int number;
        public int this[int index]
        {
            get
            {
                if ((number & (1 << index)) == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
        
        
    }
    
}
