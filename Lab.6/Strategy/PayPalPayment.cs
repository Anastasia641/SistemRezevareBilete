using System;

namespace FactoryWebApp.Lab._6
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Plata PayPal: " + amount);
        }
    }
}