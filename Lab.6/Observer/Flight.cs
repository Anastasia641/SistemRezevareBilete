using System.Collections.Generic;

namespace FactoryWebApp.Lab._6
{
    public class Flight
    {
        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void Notify(string msg)
        {
            foreach (var o in observers)
            {
                o.Update(msg);
            }
        }
    }
}