﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    interface IWithdrawable
    {
        void WithdrawMoney(decimal ammount);
    }
}
