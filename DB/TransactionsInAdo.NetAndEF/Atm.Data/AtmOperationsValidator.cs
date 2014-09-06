using System;
using System.Collections.Generic;
using Atm.Models;

namespace Atm.Data
{
    public class AtmOperationsValidator
    {
        public bool ValidatePin(string cardPin)
        {
            if (cardPin.Length < 1 || cardPin.Length > 4 || String.IsNullOrEmpty(cardPin))
            {
                return false;
            }

            return true;
        }

        public bool ValidateCardNumber(string cardNumber)
        {
            if (cardNumber.Length < 1 || cardNumber.Length > 10 || String.IsNullOrEmpty(cardNumber))
            {
                return false;
            }

            return true;
        }

        public bool ValidateCardBalance(CardAccount account, decimal withdrawAmmount)
        {
            if (account.Balance < withdrawAmmount)
            {
                return false;
            }

            return true;
        }
    }
}
