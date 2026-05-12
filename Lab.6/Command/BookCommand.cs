namespace FactoryWebApp.Lab._6
{
    public class BookCommand : Command
    {
        private BookingReceiver receiver;

        public BookCommand(BookingReceiver r)
        {
            receiver = r;
        }

        public void Execute()
        {
            receiver.Book();
        }
    }
}