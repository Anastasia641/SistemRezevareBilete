namespace FactoryWebApp.Lab3
{
    public class BookingSystem
    {
        private static BookingSystem instance;
        private BookingSystem() { }

        public static BookingSystem Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookingSystem();
                return instance;
            }
        }

        public string Connect()
        {
            return "Sistemul de rezervări este activ și unic (Singleton)!";
        }
    }
}