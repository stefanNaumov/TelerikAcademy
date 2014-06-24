using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class LoanAccount:Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate, ushort months)
            : base(customer, balance, interestRate, months)
        {

        }
        public void DepositMoney(decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentException("Cannot deposit negative sum!");
            }
            Balance += ammount;
        }
        public override decimal CalculateInterest()
        {
            if (this.Customer == Bank.Customer.Company && this.TimePeriod <= 2)
            {
                return 0;
            }
            else if (this.Customer == Bank.Customer.Individual && this.TimePeriod <= 3)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * this.TimePeriod;
            }
        }
    }
}
