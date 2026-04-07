using Lab4.Adapter;

namespace Lab4.Facade
{
    class PaymentProcessor
    {
        public void Pay(IPayment method, double amount)
        {
            method.Pay(amount);  // folosește interfața comună
        }
    }
}