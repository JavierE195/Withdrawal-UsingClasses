using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Withdrawal : ChekingAccnt
    {
        public double withdrawalAmount;

        public Withdrawal()
        {
            withdrawalAmount = 0;
        }

        public Withdrawal(double _withdrawalAmount)
        {
            withdrawalAmount = _withdrawalAmount;
        }

        public void moneyTakenOut()
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
            Console.WriteLine("Your current balance is: {0}", balance);
        }
    }
}
