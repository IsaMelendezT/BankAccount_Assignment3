using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount_Assignment3
{
    internal class Program
    {
        public class BankAccount
        {
            // FIELDS DECLARATION
            private int accountNumber;
            private string accountOwner;
            private string type = "Checking";
            private double balance = 0.0; 

            // PROPERTIES
            public int AccountNumber 
            { 
                get { return accountNumber; } 
                set {  accountNumber = value; } 
            }

            public string AccountOwner 
            {
                get { return accountOwner; }
                set { accountOwner = value; }
            }
            public double Balance
            {
                get { return balance; }
                set { balance = value; }
            }

            public string Type 
            {
                get { return type; }
                set { type = value; }
            }

            // CONSTRUCTORS

            // Default
            public BankAccount() { }

            // With All Arguments
            public BankAccount(int accountNumber, string accountOwner, string type, double balance)
            {
                this.accountNumber = accountNumber;
                this.accountOwner = accountOwner;
                this.type = type;
                this.balance = balance;
            }

            // Checking account with 0 balance and With just account number and owner as arguments
            public BankAccount(int accountNumber, string accountOwner)
            {
                this.accountNumber = accountNumber;
                this.accountOwner = accountOwner;
            }

            // Checking account with the rest of the arguments
            public BankAccount(int accountNumber, string accountOwner, double balance)
            {
                this.accountNumber = accountNumber;
                this.accountOwner = accountOwner;
                this.balance = balance;
            }
            // METHODS 

            // Deposit Methods

            // With only amount as an argument
            public void Deposit(double amount)
            {
                Balance += amount;
                Console.WriteLine($"Successfully Deposit ${amount}");
                Console.WriteLine($"New Balance {Balance}\n");
            }

            // Overload method for deposit
            public void Deposit(double amount, string type)
            {
                Balance += amount;
                Console.WriteLine($"Successfully Deposit ${amount} from ${type}");
                Console.WriteLine($"New Balance {Balance}\n");
            }


            // Withdraw Methods

            // With only amount as an argument
            public void Withdraw(double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Successfully Withdrawal ${amount}");
                    Console.WriteLine($"New Balance {Balance}\n");
                }
                else
                {
                    Console.WriteLine("Your Funds are not enough for this Withdraw");
                    Console.WriteLine($"Current Balance {Balance}\n");
                }
            }

            // With amount and transactio fee as arguments
            public void Withdraw(double amount, double transFee)
            {
                if (Balance >= amount)
                {
                    Balance -= (amount-transFee);
                    Console.WriteLine($"Successfully Withdrawal ${amount}");
                    Console.WriteLine($"New Balance {Balance}\n");
                }
                else
                {
                    Console.WriteLine("Your Funds are not enough for this Withdraw");
                    Console.WriteLine($"Current Balance: {Balance}\n");
                }
            }

        }
        static void Main(string[] args)
        {



        }
    }
}
