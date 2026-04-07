using Lab4.Adapter;
using Lab4.Composite;
using Lab4.Facade;

namespace Lab4   // <<<< aici pui namespace-ul
{
    class Lab4
    {
        public static void Run()
        {
            // Composite
            Ticket ticket = new Ticket("Bilet Chisinau - Paris");
            ticket.Add(new Service("Zbor", 200));
            ticket.Add(new Service("Bagaj", 50));
            ticket.ShowDetails();
            double total = ticket.GetPrice();

            // Adapter
            IPayment payment = new CardAdapter();

            // Facade
            BookingFacade facade = new BookingFacade();
            facade.BookFlight(payment, total);
        }
    }
}