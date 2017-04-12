using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class ChekingAccnt
    {
        public double balance;
        public double amountInsert;

        public  ChekingAccnt()
        {
            balance = 1000;
            amountInsert = 0;
        }

        public ChekingAccnt(double _amountInsert)
        {
            balance = 1000;
            amountInsert = _amountInsert;
        }

        public void Balance()
        {
            Console.WriteLine("Your current balance is: {0}", balance);
        }

       
       
    }
}
