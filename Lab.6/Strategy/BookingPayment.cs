namespace FactoryWebApp.Lab._6
{
    public class BookingPayment
    {
        private IPaymentStrategy strategy;

        public void SetStrategy(IPaymentStrategy s)
        {
            strategy = s;
        }

        public void Pay(double amount)
        {
            strategy.Pay(amount);
        }
    }
}