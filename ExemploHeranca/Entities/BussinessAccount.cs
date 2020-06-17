namespace ExemploHeranca.Entities
{
    // Herdando a classe Account
    // : representa a herança
    class BussinessAccount : Account
    {
        public double LoanLimit { get; private set; }

        // Passando os parâmetros para a classe mãe
        // O base serve para isso
        public BussinessAccount(int number, string holder, double balance, double loanLimit) : 
            base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount - 10.0;
            }   
        }
    }
}
