using System;

namespace FactoryWebApp.Lab._5
{
    public class BookingProxy
    {
        private BookingService service;
        private bool logged;

        public BookingProxy(bool l)
        {
            service = new BookingService();
            logged = l;
        }

        public void Book(string user)
        {
            if (logged)
                service.Book(user);
            else
                Console.WriteLine("Acces interzis!");
        }
    }
}