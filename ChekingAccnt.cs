using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class ChekingAccnt
    {
        private double balance = 1000;
        public double amountInsert;

        public ChekingAccnt()
        {
            amountInsert = 0;
        }

        public ChekingAccnt(double _amountInsert)
        {
            amountInsert = _amountInsert;
        }

        public double Balance()
        {
            return balance;
        }

        public double moneyWithdrawal(double withdrawalAmount)
        {
            double newBalance = balance - withdrawalAmount;
            if (newBalance < 0)
            {
                Console.WriteLine("Insuficient founds.");
            }
            else
            {
                balance = newBalance;
            }

            return balance;
        }


        public double moneyDeposited(double depositAmount)
        {
            double newBalance = balance + depositAmount;
            balance = newBalance;

            return balance;
        }
    }
}
