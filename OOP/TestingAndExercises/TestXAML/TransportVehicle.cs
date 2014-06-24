using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXAML
{
    public abstract class TrasportUnit
    {
        public string LicensePlate { get; set; }
        public int Load { get; set; }
       
        public int Capacity { get; set; }
        public bool isBeingRepaired { get; protected set; }
        public bool isOnACourse { get; protected set; }
        

        public TrasportUnit(string licensePlate, int load, int capacity)
        {
            if (this.Load >= this.Capacity)
            {
                throw new ArgumentException("Load cannot be bigger tha capacity!");
            }
            this.LicensePlate = licensePlate;
            this.Load = load;
            this.Capacity = capacity;
            
        }
        public bool IsUnitAvaliable
        {
            get { return this.isBeingRepaired == false && this.isOnACourse == false; }
        }

    }
}
