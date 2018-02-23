using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ObjectContainerDLL;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(HotelContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (context.Hotel.Any())
            {
                return;   // DB has been seeded
            }

            var hotel = new Hotel("Kodehotellet", "Inndalsveien 28, 5063 Bergen");
            context.Hotel.Add(hotel);
            context.SaveChanges();

            var rnd = new Random();
            var roomNumbers = Enumerable.Range(1, 400).ToArray();
            var list = new List<Room>();
            List<int> rndBedCount = Enumerable.Range(1, 3).Select(n => rnd.Next(3)).ToList();

            foreach (int n in roomNumbers)
            {
                var tSize = rnd.Next(1, 3);
                switch (tSize)
                {
                    case 1:
                        list.Add(new Standard(n, rndBedCount[n]));
                        break;
                    case 2:
                        list.Add(new Superior(n, rndBedCount[n]));
                        break;
                    case 3:
                        list.Add(new Suite(n, rndBedCount[n]));
                        break;
                    default:
                        break;

                }
            }

            foreach (Room r in list)
            {
                context.Rooms.Add(r);
            }
            context.SaveChanges();

            var items = new Item[]
            {
                new Item(350, "Rødvin"),
                new Item(350, "Hvitvin"),
                new Item(500, "Enkel middag"),
                new Item(1200, "Treretters middag"),
                new Item(250, "Frokost"),
                new Item(90, "Øl"),
                new Item(40, "Brus")
        };
            foreach (Item i in items)
            {
                context.Items.Add(i);
            }
            context.SaveChanges();

            
        }
    }
}