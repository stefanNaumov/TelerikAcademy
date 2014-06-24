using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MobilePhoneDevice
{
    //Task 01 - Make Class Display
    public class Display
    {
        //Fields
        private uint size;
        private uint colors;

        //Task 02 - Add constructors
        public Display()        
        {
                            //parameterless constructor
        }

        public Display(uint size = 0) //by default from the task all unknown values must be filled with null
        {
            this.size = size;
        }
        public Display(uint size = 0, uint colors = 0)
        {
            this.size = size;
            this.colors = colors;
        }
        //Task 05 - Encapsulate data fields with properties
        public uint Size
        {
            get { return this.size; }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Size of display must be greater than zero!");
                }
                this.size = value;
            }
        }
        public uint Colors
        {
            get { return this.colors; }

            set 
            {
                this.colors = value;
            }
        }
    }
}
