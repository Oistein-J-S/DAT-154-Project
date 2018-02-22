using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    /**
     * A room service order. Belongs to a booking.
     */
    public class Order
    {
        // Declarations
        private ICollection<Item> items;
        private int total;
        private DateTime created;
        private DateTime? fulfilled; // nullable DateTime

        //Best practice properties
        public ICollection<Item> Items { get => Items;}
        public int Total { get => total; }
        public DateTime Created { get => Created;}
        public DateTime? Fulfilled { get => Fulfilled;} //NB can be null!!


        public Order (ICollection<Item> items)
        {
            this.items = items;
            foreach (Item i in items)
            {
                total = +i.Value;
            }
            created = DateTime.Now;
        }

        //Not needed, as only complete orders are sent.
        /*
        public bool AddItem(string item, int cost)
        {
            if (!IsFulfilled())// Not fulfilled, ok
            {
                items.Add(item);
                total += cost;
                return true;
            }
            // The order is completed, can not add items
            return false;
        }
        */

        /**
         * fulfils this order if not allready fulfiled
         */
        public bool Fulfill()
        {
            if (!IsFulfilled())
            {
                fulfilled = DateTime.Now;
                return true;
            }
            return false;
        }

        /**
         * Returns true if this order has been completed
         */
        public bool IsFulfilled()
        {
            return fulfilled.HasValue;
        }
    }
}
