using Atm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm.Data
{
    public class AtmController
    {
        private AtmDbContext dbContext;
        private AtmOperationsValidator validator;

        public AtmController(AtmDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.validator = new AtmOperationsValidator();
        }

        public void RetrieveMoney(CardAccount account, decimal ammount)
        {
            var transaction = this.dbContext.Database.BeginTransaction(IsolationLevel.RepeatableRead);

            using (transaction)
            {
                try
                {
                    if (!this.validator.ValidatePin(account.cardPin))
                    {
                        throw new ArgumentException("Invalid CardPin! CardPin must be from 1 to 4 symbols inclusive!");
                    }

                    if (!this.validator.ValidateCardNumber(account.cardNumber))
                    {
                        throw new ArgumentException("Invalid CardNumber! CardNumber must be from 1 to 10 symbols inclusive!");
                    }

                    if (!this.validator.ValidateCardBalance(account, ammount))
                    {
                        throw new ArgumentException("The balance in the card is less than the withdrwar amount!");
                    }

                    account.Balance -= ammount;

                    TransactionHistory transHistory = new TransactionHistory()
                    {
                        CardNumberId = account.cardNumber,
                        TransactionDate = DateTime.Now,
                        Ammount = ammount
                    };

                    this.dbContext.TransactionHistories.Add(transHistory);

                    transaction.Commit();

                    this.dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                
            }
        }
    }
}
