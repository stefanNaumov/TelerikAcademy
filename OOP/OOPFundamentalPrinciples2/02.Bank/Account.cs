using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private ushort monthsPeriod;
        protected Account(Customer customer, decimal balance, decimal interestRate, ushort months)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
            this.monthsPeriod = months;
        }
        protected Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        protected decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        protected decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }
        protected ushort TimePeriod
        {
            get { return this.monthsPeriod; }
            set { this.monthsPeriod = value; }
        }
        public virtual decimal CalculateInterest()
        {
            return interestRate * monthsPeriod;
        }
        
    }
}
