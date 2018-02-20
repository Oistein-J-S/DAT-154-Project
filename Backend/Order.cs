using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Order
    {
        Booking Booking;
        List<string> Items;
        int Total { get; set; }
        DateTime Fulfilled { get; set; }

        public Order (Booking booking, List<string> items, int total)
        {
            Booking = booking;
            Items = items;
            Fulfilled = new DateTime(1970, 1, 1);
            Total = total;
        }
        
        public void AddItem(string item) { 
        Items.Add(item);
        }
        public void Fulfill()
        {
                        Fulfilled = DateTime.Now;
         }
        public bool IsFulfilled()
        {
            return Fulfilled > new DateTime(1970, 1, 1);
        }
    }
}
