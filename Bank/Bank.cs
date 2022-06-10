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

        public Bank(string cName, string cId)
        {
            CustomerName = cName;
            CustomerId = cId;
        }


    }
}
