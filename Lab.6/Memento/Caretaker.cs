using System.Collections.Generic;

namespace FactoryWebApp.Lab._6
{
    public class Caretaker
    {
        private List<Memento> history = new List<Memento>();

        public void Add(Memento m)
        {
            history.Add(m);
        }

        public Memento Get(int index)
        {
            return history[index];
        }
    }
}