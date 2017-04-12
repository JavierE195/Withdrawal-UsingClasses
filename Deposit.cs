using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Deposit : ChekingAccnt
    {
        public double depositAmount;

        public Deposit()
        {
            depositAmount = 0;
        }

        public Deposit(double _depositAmount)
        {
            depositAmount = _depositAmount;
        }

        public void moneyInserted()
        {
            double newBalance = balance + depositAmount;
            balance = newBalance;

            Console.WriteLine("Your current balance is: {0}", balance);

        }

    }
}
