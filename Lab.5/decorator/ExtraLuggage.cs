using System;

namespace FactoryWebApp.Lab._5
{
    public class ExtraLuggage : TicketDecorator
    {
        public ExtraLuggage(Ticket t) : base(t) { }

        public override string GetDescription()
        {
            return ticket.GetDescription() + ", Bagaj extra";
        }

        public override double Cost()
        {
            return ticket.Cost() + 30;
        }
    }
}