using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public class Worker: Human
    {
        private double weekSalary;
        private int workingHoursPerDay;
        private double moneyPerHour;
        public Worker(string firstName, string lastName,double weekSalary,int workHoursPerDay) : base(firstName,lastName)
        {
            if (weekSalary < 0.1)
            {
                throw new ArgumentException("Week salary cannot be zero or negative!"); //only in BG...
            }
            if (workHoursPerDay < 0 || workHoursPerDay > 24)
            {
                throw new ArgumentOutOfRangeException("Working hours cannot be less than zero or greater than 24!");
            }
            this.weekSalary = weekSalary;
            this.workingHoursPerDay = workHoursPerDay;
        }
        public int WorkHoursPerDay
        {
            set
            {
                
                this.workingHoursPerDay = value;
            }
        }
        public double WeekSalary
        {
            get { return this.weekSalary; }
        }
        public double MoneyPerHour()
        {
            double moneyPerDay = weekSalary / 5;
            moneyPerHour = moneyPerDay / workingHoursPerDay;
            return moneyPerHour;
        }
    }
}
