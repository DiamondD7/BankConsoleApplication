using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("username: ");
            string user = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Id: ");
            string Id = Console.ReadLine();

            Bank bank = new Bank(user, Id);

            bank.Views();
        }
    }
}
