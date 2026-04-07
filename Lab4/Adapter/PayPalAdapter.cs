namespace Lab4.Adapter
{
    class PayPalAdapter : IPayment
    {
        private PayPal paypal = new PayPal();

        public void Pay(double amount)
        {
            paypal.SendPayment(amount);  // adaptare la interfața standard
        }
    }

    class PayPal
    {
        public void SendPayment(double amount)
        {
            Console.WriteLine($"PayPal: Plata de {amount} efectuata.");
        }
    }
}