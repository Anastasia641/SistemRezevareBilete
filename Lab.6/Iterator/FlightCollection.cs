using System.Collections.Generic;

namespace FactoryWebApp.Lab._6
{
    public class FlightCollection
    {
        private List<int> flights = new List<int>();

        public void Add(int f)
        {
            flights.Add(f);
        }

        public List<int> GetFlights()
        {
            return flights;
        }
    }
}