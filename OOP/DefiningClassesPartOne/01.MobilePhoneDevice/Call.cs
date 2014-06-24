using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MobilePhoneDevice
{
    //Task 08 - Create a Class Call
    public class Call
    {
        //Fields
        private DateTime callDateTime;
        private uint dialedPhone;
        private uint callDuration;

        //Constructor
        public Call(DateTime dateTime,uint dialedPhone,uint callDuration)
        {
            this.callDateTime = dateTime;
            this.dialedPhone = dialedPhone;
            this.callDuration = callDuration;
        }
        //Properties

        public DateTime DateTime
        {
            get { return this.callDateTime; }

            set { this.callDateTime = value; }
        }
        public uint PhoneNumber
        {
            get { return this.dialedPhone; }
            set
            {
                if (value < 10 || value > 10)
                {
                    throw new ArgumentException("Invalid phone number! Input must be 10 numbers exactly!");
                }
                this.dialedPhone = value;
            }
        }
        public uint DurationOfCall
        {
            get { return this.callDuration; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Call duration cannot be a negative number!");
                }
                this.callDuration = value;
            }
        }
    
    }
}
