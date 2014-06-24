using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class DepositAccount:Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate, ushort months)
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
        public void WithdrawMoney(decimal ammount)
        {
            if (ammount > Balance)
            {
                throw new ArgumentException("Not enough money!");
            }
            if (ammount < 0)
            {
                throw new ArgumentException("Cannot withdraw a negative sum!");
            }
            Balance -= ammount;
        }
        public override decimal CalculateInterest()
        {
            if (this.Balance > 0 && this.Balance < 1000)
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
