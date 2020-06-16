using System;

namespace ExemploHeranca.Entities
{
    class BussinessAccount
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double LoanLimit { get; set; }

        public BussinessAccount(int number, string holder, double balance, double loanLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            LoanLimit = loanLimit;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
