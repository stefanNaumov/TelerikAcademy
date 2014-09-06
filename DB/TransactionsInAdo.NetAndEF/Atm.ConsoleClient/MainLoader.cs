using System;
using System.Collections.Generic;
using System.Linq;
using Atm.Models;
using Atm.Data;

//Using transactions write a method which retrieves some money (for example $200) from certain account. The retrieval is successful when the following sequence of sub-operations is completed successfully:
//A query checks if the given CardPIN and CardNumber are valid.
//The amount on the account (CardCash) is evaluated to see whether it is bigger than the requested sum (more than $200).
//The ATM machine pays the required sum (e.g. $200) and stores in the table CardAccounts the new amount (CardCash = CardCash - 200).
//Why does the isolation level need to be set to “repeatable read”?

//ANSWER: When having Repeatable Read Isolation Level, writers only block other writers, but not readers. 
namespace Atm.ConsoleClient
{
    class MainLoader
    {
        static void Main()
        {
            AtmDbContext dbContext = new AtmDbContext();
            AtmController controller = new AtmController(dbContext);
            for (int i = 1; i <= 3; i++)
            {
                CardAccount account = new CardAccount()
                {
                    //concatenating strings is bad, but for this test case is ok
                    cardNumber = "1234567" + i.ToString(),
                    Balance = 200 + i,
                    cardPin = "000" + i.ToString()
                };

                dbContext.CardAccounts.Add(account);
                Console.WriteLine("New card added succesfully! ");
            }
            CardAccount newAccount = new CardAccount()
            {
                cardNumber = "12345579",
                Balance = 260,
                cardPin = "140"
            };
            decimal ammount = 50;
            dbContext.CardAccounts.Add(newAccount);
            Console.WriteLine("New card added succesfully! ");
            controller.RetrieveMoney(newAccount, ammount);
            Console.WriteLine("{0} money retrieved succesfully from account {1}",ammount, newAccount.Id);
            dbContext.SaveChanges();
        }
    }
}
