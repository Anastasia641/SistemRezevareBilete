using System;

namespace FactoryWebApp.Lab._5
{
    public class PayPalPayment : PaymentMethod
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Plata PayPal: " + amount);
        }
    }
}