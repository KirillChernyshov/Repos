using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Apartment
    {
        public string District { get; set; }
        public int Floor { get; set; }
        public int AmountOfRooms { get; set; }
        public double Area { get; set; }
        public int PricePerSquareMeter { get; set; }
        public int OverallPriority { get; set; }

        public Apartment(string district, int floor, int amountOfRooms, double area, int pricePerSquareMeter)
        {
            District = district;
            Floor = floor;
            AmountOfRooms = amountOfRooms;
            Area = area;
            PricePerSquareMeter = pricePerSquareMeter;
        }
    }
}
