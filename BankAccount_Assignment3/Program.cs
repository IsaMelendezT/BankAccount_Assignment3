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
                Console.WriteLine($"Successfully Deposit ${amount} to account number: {AccountNumber}");
                Console.WriteLine($"New Balance ${Balance}\n");
            }

            // Overload method for deposit
            public void Deposit(double amount, string type)
            {
                Balance += amount;
                Console.WriteLine($"Successfully Deposit ${amount} from {type} to account number: {AccountNumber}");
                Console.WriteLine($"New Balance ${Balance}\n");
            }


            // Withdraw Methods

            // With only amount as an argument
            public void Withdraw(double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Successfully Withdrawal ${amount} from account number: {AccountNumber}");
                    Console.WriteLine($"New Balance ${Balance}\n");
                }
                else
                {
                    Console.WriteLine("Your Funds are not enough for this Withdraw");
                    Console.WriteLine($"Current Balance ${Balance}\n");
                }
            }

            // With amount and transactio fee as arguments
            public void Withdraw(double amount, double transFee)
            {
                if (Balance >= amount)
                {
                    Balance -= (amount+transFee);
                    Console.WriteLine($"Successfully Withdrawal ${amount} from account number: {AccountNumber}");
                    Console.WriteLine($"Transaction Fee: {transFee}");
                    Console.WriteLine($"New Balance {Balance}\n");
                }
                else
                {
                    Console.WriteLine("Your Funds are not enough for this Withdraw");
                    Console.WriteLine($"Current Balance: {Balance}\n");
                }
            }
        }
        private static void PrintAccountDetails(BankAccount account)
        {
            var number = account.AccountNumber;
            var owner = account.AccountOwner;
            var balance = account.Balance;
            var type = account.Type;

            Console.WriteLine(
                $"---------------------------------------------\n"+
                $"Account details \n" +
                $"Owner: {owner} \n" +
                $"Number: {number} \n" +
                $"Balance: {balance} \n" +
                $"Type: {type}\n"
                );
        }
        static void Main(string[] args)
        {

            // Create account 1 with default constructor
            BankAccount account1 = new BankAccount();
            account1.AccountNumber = 36524563;
            account1.AccountOwner = "Maria Melendez";
            account1.Type = "Savings";
            
            // Print Account 1 details 
            PrintAccountDetails(account1);

            // Deposit  1000 to account 1
            account1.Deposit(1000);

            // Create account 2 with full argument constructor 
            BankAccount account2 = new BankAccount(45653598, "Nicolas Mateus", "Savings", 3000);

            // Print account 2 details
            PrintAccountDetails(account2);

            // Withdraw 2000 from account 2, transaction fee 5 dollars 
            account2.Withdraw(2000, 5);

            // Create a checking account 3 with 0 balance
            BankAccount account3 = new BankAccount(36548932, "Stella Torres");

            // Print accoun3 details
            PrintAccountDetails(account3);

            // Deposit a cheque with 5000
            account3.Deposit(3000, "Cheque");

            // Create a checking account4
            BankAccount account4 = new BankAccount(23659874, "Victoria Rosas", 4500);

            //Print account4 details
            PrintAccountDetails(account4);

            //Try to withdraw 5000 dollars 
            account4.Withdraw(5000);



        }
    }
}
