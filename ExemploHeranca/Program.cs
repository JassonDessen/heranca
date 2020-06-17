using System;
using ExemploHeranca.Entities;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BussinessAccount bacc = new BussinessAccount(1002, "Maria", 0.0, 500.0);

            // Upcasting
            // Conversão de subclasse para superclasse
            // Account pode receber um BussinessAccount, pois o BussinessAccount é uma herança de Account
            Account acc1 = bacc;
            Account acc2 = new BussinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            // Downcasting
            // Conversão de superclasse para subclasse
            BussinessAccount acc4 = (BussinessAccount)acc2;
            acc4.Loan(100);

            if (acc3 is BussinessAccount)
            {
                BussinessAccount acc5 = (BussinessAccount)acc3;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }
            else if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
