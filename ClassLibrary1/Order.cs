using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    /**
     * A room service order. Belongs to a booking.
     */
    class Order
    {
        // Declarations
        private List<string> items;
        private int total;
        private DateTime created;
        private DateTime? fulfilled; // nullable DateTime

        //Best practice properties
        public List<string> Items { get => Items;}
        public int Total { get => total; }
        public DateTime Created { get => Created;}
        public DateTime? Fulfilled { get => Fulfilled;} //NB can be null!!


        public Order (List<string> items, int total)
        {
            this.items = items;
            this.total = total;
            created = DateTime.Now;
        }
        
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
