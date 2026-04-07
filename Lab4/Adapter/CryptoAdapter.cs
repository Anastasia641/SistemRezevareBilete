namespace Lab4.Adapter
{
    class CryptoAdapter : IPayment
    {
        private Crypto crypto = new Crypto();

        public void Pay(double amount)
        {
            crypto.Transfer(amount);  // adaptare la interfața standard
        }
    }

    class Crypto
    {
        public void Transfer(double amount)
        {
            Console.WriteLine($"Crypto: Plata de {amount} efectuata.");
        }
    }
}