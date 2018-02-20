using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    /**
     * A room service order. Belongs to a booking.
     */
    class Order
    {
        List<string> Items;
        int Total { get; set; }
        DateTime Created { get; set; }
        DateTime Fulfilled { get; set; }

        public Order (List<string> items, int total)
        {
            Items = items;
            Fulfilled = new DateTime(1970, 1, 1);
            Total = total;
            Created = DateTime.Now;
        }
        
        public bool AddItem(string item, int cost)
        {
            if (!IsFulfilled())// Not fulfilled, ok
            {
                Items.Add(item);
                Total += cost;
                return true;
            }
            // The order is completed, can not add items
            return false;
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
