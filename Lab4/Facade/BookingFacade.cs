using Lab4.Adapter;

namespace Lab4.Facade
{
    class BookingFacade
    {
        private FlightSearch search = new FlightSearch();
        private SeatBooking seat = new SeatBooking();
        private PaymentProcessor payment = new PaymentProcessor();
        private Notification notification = new Notification();

        public void BookFlight(IPayment method, double amount)
        {
            search.Search();
            seat.Reserve();
            payment.Pay(method, amount);
            notification.Send();
        }
    }
}