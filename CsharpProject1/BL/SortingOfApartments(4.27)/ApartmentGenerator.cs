using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ApartmentGenerator
    {
        Apartment[] Apartaments { get; set; }

        string[] districts = { "Северный", "Южный", "Восточный", "Западный" };
        double[] area = { 36, 42, 54, 62, 68, 82 };
        int[] pricesPerSquareMeter = { 38900, 39000, 37000 };
        
        public Apartment[] Generate(int amount)
        {
            Apartaments = new Apartment[amount];
            Random random = new Random();

            for(int i = 0; i < amount; i++)
            {
                string dist = districts[random.Next(4)];
                int floor = random.Next(1, 11);
                int rooms = random.Next(1, 4);
                double ar = area[random.Next(rooms*2-2, rooms*2-1)];
                int price = pricesPerSquareMeter[random.Next(3)];

                Apartaments[i] = new Apartment(dist, floor, rooms, ar, price);
            }

            return Apartaments;
        }
    }
}
