namespace FactoryWebApp.Lab._5
{
    public abstract class TicketDecorator : Ticket
    {
        protected Ticket ticket;

        public TicketDecorator(Ticket t)
        {
            ticket = t;
        }

        public virtual string GetDescription()
        {
            return ticket.GetDescription();
        }

        public virtual double Cost()
        {
            return ticket.Cost();
        }
    }
}