using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MobilePhoneDevice
{
    //Task 01 - Make class Battery
    public class Battery
    {
        //Fields
        private string model;
        private uint hoursIdle;
        private uint hoursTalk;
        private BatteryType typeOfBattery;

        //Task 02 - Add constructors
        public Battery()
        {
                            //parameterless constructor
        }
        public Battery(string model, uint hoursIdle = 0,uint hoursTalk = 0)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;                 //constructor with parameters
            this.hoursTalk = hoursTalk;
        }
        public Battery(string model, uint hoursIdle = 0, uint hoursTalk = 0,BatteryType typeOfBattery = BatteryType.LiIon)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;                 //constructor with parameters
            this.hoursTalk = hoursTalk;
            this.typeOfBattery = typeOfBattery;
        }
        //Task 05 - Encapsulate data fields 
        //Properties with validation of input
        public string Model
        {
            get
            { return this.model; }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid model name");
                }
                this.model = value;
            }
        }
        public uint HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Talking hours cannot be negative!");
                }
                this.hoursTalk = value;
            }
        }
        public uint HoursIdle
        {
            get { return this.HoursIdle; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Hours idle cannot be a negative value!");
                }
                this.HoursIdle = value;
            }
        }
    }
}
