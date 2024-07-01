using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{

    internal class Account
    {

        public event Operation overBalance;
        public event Operation underBalance;
        public double balance { get; set; }

        public void withdraw(double amount)
        {
            double tempAmt = balance - amount;
            monitor(tempAmt);
            balance = tempAmt;

        }
        public void deposit(double amount)
        {
            double tempAmt = balance + amount;
            monitor(tempAmt);
            balance = tempAmt;

        }

        public void monitor(double amount)
        {
            if (amount > 250000)
            {
                overBalance();
            }
            else if (amount < 10000)
            {
                underBalance();
            }
        }
    }
}

