using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            int answer2;
            bool state = true;


            while (state == true)
            {
                Console.WriteLine("\n1. Check Balance"
                    + "\n2. Deposit"
                    + "\n3. Withdrawal"
                    + "\n4. Exit"
                    + " ");
                Console.Write("\nPlease select a number of the options option: ");
                answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {
                    ChekingAccnt firstOption = new ChekingAccnt();
                    firstOption.Balance();

                    Console.Write("\nWould you like to make any other transaction? Please select a number. "
                        + "\n1. Yes "
                        + "\n2. No "
                        + "\n");
                    answer2 = int.Parse(Console.ReadLine());

                    if (answer2 == 2)
                    {
                        state = false;
                    }
                }
                else if (answer == 2)
                {
                    Console.Write("\nPlease insert the amount to deposit: ");
                    double amountIn = double.Parse(Console.ReadLine());

                    ChekingAccnt Deposit = new ChekingAccnt();
                    double balance = Deposit.moneyInserted(amountIn);

                    Console.WriteLine("Your current balance is: " + balance);

                    Console.Write("\nWould you like to make any other transaction? Please select a number. "
                        + "\n1. Yes "
                        + "\n2. No "
                        + "\n");
                    answer2 = int.Parse(Console.ReadLine());

                    if (answer2 == 2)
                    {
                        state = false;
                    }
                }
                else if (answer == 3)
                {
                    Console.Write("\nPlease insert the amount to withdrawal: ");
                    double amountIn = double.Parse(Console.ReadLine());

                    ChekingAccnt Withdrawal = new ChekingAccnt();
                    double balance = Withdrawal.moneyTakenOut(amountIn);

                    Console.WriteLine("Your current balance is: " + balance);

                    Console.Write("\nWould you like to make any other transaction? Please select a number. "
                        + "\n1. Yes "
                        + "\n2. No "
                        + "\n");
                    answer2 = int.Parse(Console.ReadLine());

                    if (answer2 == 2)
                    {
                        state = false;
                    }

                }
                else if (answer == 4)
                {
                    state = false;
                }

                else
                {
                    Console.WriteLine("Please select a number from 1 to 4. ");
                }
               
            }
            Console.WriteLine("\nHave a wonderful day. ");
            Console.ReadKey();
        }
    }
}