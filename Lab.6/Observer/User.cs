using System;

namespace FactoryWebApp.Lab._6
{
    public class User : IObserver
    {
        private string name;

        public User(string n)
        {
            name = n;
        }

        public void Update(string message)
        {
            Console.WriteLine(name + " a primit: " + message);
        }
    }
}