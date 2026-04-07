using System.Collections.Generic;

namespace Lab4.Composite
{
    class Ticket : IFlightComponent
    {
        public string TicketName { get; set; }
        private List<IFlightComponent> components = new List<IFlightComponent>();

        public Ticket(string ticketName)
        {
            TicketName = ticketName;
        }

        public void Add(IFlightComponent component)
        {
            components.Add(component);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Bilet: {TicketName}");
            foreach (var c in components)
            {
                c.ShowDetails();
            }
        }

        public double GetPrice()
        {
            double total = 0;
            foreach (var c in components)
            {
                total += c.GetPrice();
            }
            return total;
        }
    }
}