namespace FactoryWebApp.Lab._6
{
    public class Memento
    {
        private string state;

        public Memento(string s)
        {
            state = s;
        }

        public string GetState()
        {
            return state;
        }
    }
}