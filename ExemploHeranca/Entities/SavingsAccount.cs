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

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
