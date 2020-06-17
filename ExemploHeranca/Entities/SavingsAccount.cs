namespace ExemploHeranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }

        // O base acessa o contrutor da classe mãe
        public SavingsAccount(int number, string holder, double balance, double interestRate) :
            base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(double amount)
        {
            // Executa o código do método Withdraw da classe Account
            base.Withdraw(amount);
            // E subtrai mais 2,00 reais do saldo
            Balance -= 2.0;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
