namespace FactoryWebApp.Lab3
{
    public class TicketDirector
    {
        // Poți defini mai multe tipuri de bilete
        public FlightTicket BuildEconomyTicket(ITicketBuilder builder)
        {
            builder.SetPassenger("Ana Popescu");
            builder.SetDestination("Paris");
            builder.SetSeatClass("Economy");
            builder.AddExtraBaggage(false);
            return builder.GetTicket();
        }

        public FlightTicket BuildBusinessTicket(ITicketBuilder builder)
        {
            builder.SetPassenger("Alex Ionescu");
            builder.SetDestination("New York");
            builder.SetSeatClass("Business");
            builder.AddExtraBaggage(true);
            return builder.GetTicket();
        }
    }
}