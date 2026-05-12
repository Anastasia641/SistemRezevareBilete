using System;

namespace FactoryWebApp.Lab._5
{
    public class FlightBooking : Booking
    {
        public FlightBooking(PaymentMethod p) : base(p)
        {
        }

        public override void Book(double price)
        {
            Console.WriteLine("Rezervare zbor...");
            payment.Pay(price);
        }
    }
}