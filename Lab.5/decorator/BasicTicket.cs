using System;

namespace FactoryWebApp.Lab._5
{
    public class BasicTicket : Ticket
    {
        public string GetDescription()
        {
            return "Bilet avion";
        }

        public double Cost()
        {
            return 100;
        }
    }
}