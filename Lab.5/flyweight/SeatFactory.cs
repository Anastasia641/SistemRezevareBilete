using System.Collections.Generic;

namespace FactoryWebApp.Lab._5
{
    public class SeatFactory
    {
        private static Dictionary<string, SeatType> seats = new();

        public static SeatType GetSeat(string key)
        {
            if (!seats.ContainsKey(key))
            {
                if (key == "ECONOMY")
                    seats[key] = new SeatType("Economy", "Low");
                else if (key == "BUSINESS")
                    seats[key] = new SeatType("Business", "Medium");
                else
                    seats[key] = new SeatType("First", "High");
            }

            return seats[key];
        }
    }
}