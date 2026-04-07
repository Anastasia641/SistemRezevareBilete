namespace Lab4.Adapter
{
    class CardAdapter : IPayment
    {
        private BankCard card = new BankCard();

        public void Pay(double amount)
        {
            card.ProcessTransaction(amount);  // adaptare la interfața standard
        }
    }

    class BankCard
    {
        public void ProcessTransaction(double amount)
        {
            Console.WriteLine($"Card: Plata de {amount} efectuata.");
        }
    }
}