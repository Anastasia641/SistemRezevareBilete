namespace FactoryWebApp.Lab3
{
    public interface IPrototype
    {
        IPrototype Clone();
    }

    public class Reservation : IPrototype
    {
        public string PassengerName { get; set; }
        public string FlightNumber { get; set; }

        public IPrototype Clone()
        {
            return (Reservation)this.MemberwiseClone(); // copie superficială
        }
    }
}