namespace FactoryWebApp.Lab3
{
    public class TicketBuilder : ITicketBuilder
    {
        private FlightTicket ticket = new FlightTicket();

        public void SetPassenger(string name) => ticket.PassengerName = name;
        public void SetDestination(string destination) => ticket.Destination = destination;
        public void SetSeatClass(string seatClass) => ticket.SeatClass = seatClass;
        public void AddExtraBaggage(bool baggage) => ticket.ExtraBaggage = baggage;

        public FlightTicket GetTicket() => ticket;
    }
}