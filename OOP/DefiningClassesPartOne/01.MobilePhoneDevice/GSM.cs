using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MobilePhoneDevice
{
    //Task 01 - Make Class GSM with instances of the Classes Battery and Display
    public class GSM
    {
        Battery battery =  new Battery();
        Display display = new Display();
        private string manifacturer;
        private string model;
        private uint price;
        private string owner;
        //Task 06 - Add static field IPhone4s
        //see property below
        private static GSM IPhone4S = new GSM("IPhone4S","Apple","Pesho",1200);

        //Task 09 - add a CallHistory field
        //see property below
        private List<Call> callHistory = new List<Call>();
        
        //Constructors
        public GSM()
        {

        }
        public GSM(string model,string manifacturer)
        {
            this.model = model;
            this.manifacturer = manifacturer;
        }
        public GSM(string model, string manifacturer, string owner)
        {
            this.model = model;
            this.manifacturer = manifacturer;
            this.owner = owner;
        }
        public GSM(string model, string manifacturer, string owner, uint price)
        {
            this.model = model;
            this.manifacturer = manifacturer;
            this.owner = owner;
            this.price = price;
        }
        public GSM(string model, string manifacturer, string owner, uint price,Battery battery)
        {
            this.model = model;
            this.manifacturer = manifacturer;
            this.owner = owner;
            this.price = price;
            this.battery = battery;
        }
        public GSM(string model, string manifacturer, string owner, uint price, Battery battery,Display display)
        {
            this.model = model;
            this.manifacturer = manifacturer;
            this.owner = owner;
            this.price = price;
            this.battery = battery;
            this.display = display;
        }
        //Task 05 - Encapsulate data fields with properties
        public BatteryType batterytype
        {
            get { return this.batterytype; }
        }
        public string Model
        {
            get { return this.model; }

            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid model name!");
                }
                this.model = value;
            }
        }
        public string Manifacturer
        {
            get { return this.manifacturer; }

            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid manifacturer name!");
                }
                this.manifacturer = value;
            }
        }
        public uint Price
        {
            get { return this.price; }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Phone price cannot be a negative number!");
                }
                this.price = value;
            }
        }
        public string OwnerName
        {
            get { return this.owner; }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid input for phone owner!");
                }
                this.owner = value;
            }
        }
        //Task 06 - Iphone4s static property
        public static GSM IPhone //field is also static
        {
            get { return IPhone4S; }
        }
        //Task 09 - Add a CallHistory property
        public List<Call> CallHistory
        {
            get { return this.callHistory; }

            set { this.callHistory = value; }
        }

        //Task 10 - Method to add calls to CallHistory
        public void AddCallTohistory(Call currentCall)
        {
            CallHistory.Add(currentCall);
        }

        //Task 10 - Method to delete calls from history
        public void DeleteCallFromHistory(Call currentCall)
        {
            CallHistory.Remove(currentCall);
        }

        //Task 10 - Method to clear calls from history
        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        //Task 11 + 12 - Method to calculate the price of the calls in the history
        public void CalculateCallPrice()
        {
            double sum = 0;
            foreach (var item in callHistory)
            {
                sum += (int)(item.DurationOfCall / 60) * 0.37;
            }
            Console.WriteLine("Price of the calls in history: {0}",sum);
           
        }

        //Task 12 - Add couple of methods
        public void DisplayCallInfo()
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                Console.WriteLine("Conversation with number: {0}",callHistory[i].PhoneNumber);
                Console.WriteLine("Duration of call {0}: {1} seconds", i + 1, callHistory[i].DurationOfCall);
                
            }
        }
        public void RemoveLongestCallFromHistory()
        {
            uint longestCallLength = 0;
            int longestCallPosition = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].DurationOfCall > longestCallLength)
                {
                    longestCallLength = callHistory[i].DurationOfCall;
                    longestCallPosition = i;
                }
            }
            callHistory.RemoveAt(longestCallPosition);
        }

        //Task 04 - override ToString method
        public override string ToString()
        {
            StringBuilder phoneInfo = new StringBuilder();
            phoneInfo.AppendLine("Manifacturer **** " + manifacturer + " ****");
            phoneInfo.AppendLine("Model name **** " + model + " ****");
            phoneInfo.AppendLine("Phone price **** " + price + " ****");
            phoneInfo.AppendLine("Owner **** " + owner + " ****");
            
            return phoneInfo.ToString();
        }
    }
}
