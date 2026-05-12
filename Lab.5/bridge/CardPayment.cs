using System;

namespace FactoryWebApp.Lab._5
{
    public class CardPayment : PaymentMethod
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Plata cu card: " + amount);
        }
    }
}