using System;

namespace FactoryWebApp.Lab._5
{
    public class SeatType
    {
        public string Type { get; set; }
        public string PriceCategory { get; set; }

        public SeatType(string type, string priceCategory)
        {
            Type = type;
            PriceCategory = priceCategory;
        }

        public void Show()
        {
            Console.WriteLine("Seat: " + Type + " | " + PriceCategory);
        }
    }
}