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
    }
}
