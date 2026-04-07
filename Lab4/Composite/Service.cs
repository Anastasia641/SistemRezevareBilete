namespace Lab4.Composite
{
    class Service : IFlightComponent
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Service(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Serviciu: {Name}, Pret: {Price}");
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}