using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{
    internal class Program
    {
        class BankApplication
        {
            int Amount = 20000;
            static String Bank_name = "HDFC";
            static public int Total_balance;
            String Account_holder = "Vamsikrishna";
            String Account_number;
            public void Depositamount()
            {

                Console.WriteLine("Enter Your deposite  Amount :");
                int En_depositemoney = int.Parse(Console.ReadLine());
                Total_balance = Amount +En_depositemoney;
                if (En_depositemoney <= 100  )
                {
                    Console.WriteLine("Please Enter the minimum 100 rupees like...100,200,500,1000");
                }
                else
                {
                    Console.WriteLine("Total your account  balance is.... :{0}", Total_balance);
                }

            }
            public void WithdrawMoney()
            {
                try
                {
                   
                    Console.WriteLine("Please Enter Withdrawamount... :");
                    int Withdraw_Amount = int.Parse(Console.ReadLine());
                    int  Newtotal_balance= Total_balance - Withdraw_Amount;
                    if (Withdraw_Amount< Total_balance && Withdraw_Amount%20==0 )
                    {
                        Console.WriteLine("Insuffiecient Balance");
                    }
                    else
                    { 
                        Console.WriteLine("Your  amount is ...:{0} ",Amount);
                        Console.WriteLine("Your total amount is ...:{}", Newtotal_balance);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Please Enter the valid numbers......");
                    Console.WriteLine("Your Enter invalid choices ........");
                }
            }
            public void Balance()
            {
                Console.WriteLine("Hi!...Welcome To {0} Bank ",Bank_name);
                Console.WriteLine("Please Enter Account Number.....: ");
                Account_number = Console.ReadLine();
                Console.WriteLine("Welcome {0} Your AccountBalance: {1}" ,Account_holder, Amount);

            }
        }
        static void Main(string[] args)
        {
            BankApplication app= new BankApplication();
            Console.WriteLine("Welcome to bank.....");
            Console.WriteLine("Depositamount for 1.....");
            Console.WriteLine(" WithdrawMoney for 2.....");
            Console.WriteLine(" Balance for 3.....");
            Console.WriteLine("Select Your Option .....:");
            int option=int.Parse(Console.ReadLine());
            if (option == 1)
            {
                app.Depositamount();
                Console.WriteLine("Thankyou For Visit Bye.....");

            }

            else if (option == 2)
            {

                app.WithdrawMoney();
                Console.WriteLine("TakeCare Of  Your Cash Bye .....");
            }
            else if (option == 3)
            {
                app.Balance();
                Console.WriteLine("Your Amount Is Safe Bye.....");

            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.ReadLine();
        }
    }
}