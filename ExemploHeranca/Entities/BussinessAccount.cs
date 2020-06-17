using System;

namespace ExemploHeranca.Entities
{
    class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }

        // Passando os parâmetros para a classe mãe
        // O base serve para isso
        public BussinessAccount(int number, string holder, double balance, double loanLimit) : 
            base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            
        }
    }
}
