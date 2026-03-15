namespace FactoryWebApp.Lab3
{
    public interface ITicketBuilder
    {
        void SetPassenger(string name);
        void SetDestination(string destination);
        void SetSeatClass(string seatClass);
        void AddExtraBaggage(bool baggage);
        FlightTicket GetTicket();
    }
}