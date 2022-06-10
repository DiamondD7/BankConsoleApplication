﻿using System;
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
            if (amount != 0) balance += amount;
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
            int amnt = 0;
            Console.WriteLine($"Welcome to the NZ Bank {CustomerName}");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("A. Deposit");
            Console.WriteLine("B. Withdraw");
            Console.WriteLine("C. Check Balance");
            Console.WriteLine("D. Exit");
            Console.WriteLine();
            do
            {
                Console.Write("Enter option: ");
                option = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (option)
                {
                    case 'A':
                        Console.Write("How much would you like to deposit: $");
                        amnt = Convert.ToInt32(Console.ReadLine());
                        Deposit(amnt);
                        break;
                    case 'B':
                        do
                        {
                            if (amnt > balance) Console.WriteLine("Please enter the right amount");
                            Console.Write("How much would you like to withdraw: $");
                            amnt = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Withdrawal successful");
                            
                        } while (amnt > balance);
                        Withdraw(amnt);
                        break;
                    case 'C':
                        CheckBalance();
                        break;
                    case 'D':
                        Console.WriteLine("Thank you for choosing!");
                        break;
                    default:
                        Console.WriteLine("Please enter the right option");
                        break;
                }

            } while (option != 'D');

            Console.WriteLine("Goodbye, see you next time!");
        }
    }
}
