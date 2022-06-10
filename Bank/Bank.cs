using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public string CustomerName { get; set; }
        public string CustomerId { get; set; }
        int balance;

        public Bank(string cName, string cId)
        {
            CustomerName = cName;
            CustomerId = cId;
        }

        public void Deposit(int amount)
        {
            if(amount != 0) balance += amount;
        }
        public void Withdraw(int amount)
        {
            if (amount != 0) balance -= amount;
        }
        public void CheckBalance()
        {
            Console.WriteLine($"Your available balance is: {balance}");
        }
        public void Views()
        {
            char option = ' ';
            Console.WriteLine("Welcome to the NZ Bank!");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("A. Deposit");
            Console.WriteLine("B. Withdraw");
            Console.WriteLine("C. Check Balance");
            Console.WriteLine("D. Exit");
            Console.WriteLine();
            Console.Write("Please choose any option: ");
            option = Convert.ToChar(Console.ReadLine());


        }
    }
}
