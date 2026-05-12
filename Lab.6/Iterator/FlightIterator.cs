using System.Collections.Generic;

namespace FactoryWebApp.Lab._6
{
    public class FlightIterator : Iterator
    {
        private List<int> flights;
        private int index = 0;

        public FlightIterator(List<int> f)
        {
            flights = f;
        }

        public bool HasNext()
        {
            return index < flights.Count;
        }

        public int Next()
        {
            return flights[index++];
        }
    }
}