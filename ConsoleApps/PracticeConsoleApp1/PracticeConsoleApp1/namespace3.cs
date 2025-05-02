using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
✅ Task 3: Bank Account System (Encapsulation)
Goal: Create a BankAccount class with private fields like balance. Use public methods to Deposit(), Withdraw() and GetBalance().

Keywords to practice: private, public, encapsulation, this 
*/

namespace PracticeConsoleApp1
{
    public class BankAccount
    {
        private double balance;
        private int choice;
        public BankAccount()
        {
            this.balance = 0;
            this.choice = 0;
        }
        public void Menu()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("1. To Depost Amount");
            Console.WriteLine("2. To Withdraw Amount");
            Console.WriteLine("3. To Check Balance");
            Console.WriteLine("=====================");
            Console.WriteLine("Enter your choice: ");
            this.choice = Convert.ToInt32(Console.ReadLine());
            this.runProcess();
        }
        public void runProcess()
        {
            switch (choice)
            {
                case 1:
                    {
                        this.deposit();
                        break;
                    }
                case 2:
                    {
                        this.withDraw();
                        break;
                    }
                case 3:
                    {
                        this.GetBalance();
                        break;
                    }
            }

            Console.WriteLine("To continue press 1: ");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                this.Menu();
            }
            else
            {
                Console.WriteLine("Process End");
            }

        }

        public void deposit()
        {
            Console.WriteLine("Enter Amount: ");
            this.balance += Convert.ToDouble(Console.ReadLine());
        }
        public void withDraw()
        {
            Console.WriteLine("Enter Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount <= this.balance) {
                this.balance = this.balance - amount;
                Console.WriteLine("Amount withdraw successfully");
            }
            else
            {
                Console.WriteLine("Some Error.....");
            }
        }

        public void GetBalance()
        {
            Console.WriteLine("Current Balance: " + this.balance);
        }
    }
}
