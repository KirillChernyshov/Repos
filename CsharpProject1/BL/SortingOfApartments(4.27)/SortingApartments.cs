using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /* Задача 4.1.27
        Информация агентства по продаже недвижимости содержит следующие сведения о квартирах:
            ü район, в котором находится квартира,
            ü этаж,
            ü количество комнат,
            ü общая площадь,
            ü цена за 1 м2.
        Клиент, обращаясь в агентство, имеет возможность указать вес для каждого из критериев 
        (важный критерий имеет большой вес, незначительный – маленький), а агентство, в свою очередь, 
        предлагает ему список квартир, упорядоченный по невозрастанию суммы весов.
    */
    public class SortingApartments
    {
        public Apartment[] Apartments { get; set; }

        public SortingApartments(Apartment[] apartments)
        {
            Apartments = apartments;
        }

        public Apartment[] SortApartments(List<Query> query)
        {
            CalculatePriority(query);

            List<Apartment> ap = new List<Apartment>();
            Apartments = Apartments.OrderByDescending(i => i.OverallPriority).ToArray();
            return Apartments;
        }

        void CalculatePriority(List<Query> query)
        {
            for (int i = 0; i < Apartments.Length; i++)
            {
                Apartments[i].OverallPriority = 0;
                for (int j = 0; j < query.Count; j++)
                {
                    if (query[j].Criterion == "Район")
                    {
                        if (query[j].Value == Apartments[i].District)
                            Apartments[i].OverallPriority += query[j].Priority;
                        continue;
                    }
                    if (query[j].Criterion == "Этаж")
                    {
                        if (query[j].Value == Apartments[i].Floor.ToString())
                            Apartments[i].OverallPriority += query[j].Priority;
                        continue;
                    }
                    if (query[j].Criterion == "Комнат")
                    {
                        if (query[j].Value == Apartments[i].AmountOfRooms.ToString())
                            Apartments[i].OverallPriority += query[j].Priority;
                        continue;
                    }
                    if (query[j].Criterion == "Площадь")
                    {
                        if (query[j].Value == Apartments[i].Area.ToString())
                            Apartments[i].OverallPriority += query[j].Priority;
                        continue;
                    }
                    if (query[j].Criterion == "Цена")
                    {
                        if (query[j].Value == Apartments[i].PricePerSquareMeter.ToString())
                            Apartments[i].OverallPriority += query[j].Priority;
                    }
                }
            }
        }
    }
}
