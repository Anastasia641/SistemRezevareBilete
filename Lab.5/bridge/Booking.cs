namespace FactoryWebApp.Lab._5
{
    public class Booking
    {
        protected PaymentMethod payment;

        public Booking(PaymentMethod p)
        {
            payment = p;
        }

        public virtual void Book(double price)
        {
            payment.Pay(price);
        }
    }
}