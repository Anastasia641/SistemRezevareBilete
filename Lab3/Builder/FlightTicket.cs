namespace FactoryWebApp.Lab3
{
    public class FlightTicket
    {
        public string PassengerName { get; set; }
        public string Destination { get; set; }
        public string SeatClass { get; set; }
        public bool ExtraBaggage { get; set; }

        public void ShowTicket()
        {
            // Aceasta e versiunea pentru console (web o vom afișa în ViewData)
            System.Console.WriteLine($"Pasager: {PassengerName}");
            System.Console.WriteLine($"Destinație: {Destination}");
            System.Console.WriteLine($"Clasa: {SeatClass}");
            System.Console.WriteLine($"Bagaj extra: {(ExtraBaggage ? "Da" : "Nu")}");
        }
    }
}