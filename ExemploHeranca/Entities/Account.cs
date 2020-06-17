using System;

namespace ExemploHeranca.Entities
{
    class Account
    {
        public int Number { get; private  set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // A palavra virtual permite que o método seja sobrescrito na subclasse.
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return $"Número: {Number}, Títular: {Holder}, Saldo: {Balance.ToString("F2")}!"; 
        }
    }
}
