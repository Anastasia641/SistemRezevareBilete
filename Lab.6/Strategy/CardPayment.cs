using System;

namespace FactoryWebApp.Lab._6
{
    public class CardPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Plata cu card: " + amount);
        }
    }
}