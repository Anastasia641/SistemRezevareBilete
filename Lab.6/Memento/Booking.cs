namespace FactoryWebApp.Lab._6
{
    public class Booking
    {
        private string state;

        public void SetState(string s)
        {
            state = s;
        }

        public string GetState()
        {
            return state;
        }

        public Memento Save()
        {
            return new Memento(state);
        }

        public void Restore(Memento m)
        {
            state = m.GetState();
        }
    }
}