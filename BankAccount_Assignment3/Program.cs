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
            // Fields Declaration 
            private int accountNumber;
            private string type = "Checking";
            private double balance = 0.0; 

            // Properties
            public int AccountNumber 
            { 
                get { return accountNumber; } 
                set {  accountNumber = value; } 
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


            

        }
        static void Main(string[] args)
        {



        }
    }
}
