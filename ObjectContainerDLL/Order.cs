using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        //Best practice properties
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderID { get; set; }
        public int Total { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Fulfilled { get; set; } //NB can be null!!
        public ICollection<Item> Items { get; set; }


        public Order (string name, int price)
        {
            Created = DateTime.Now;
            Items.Add(new Item(price, name));
        }

        public Order (ICollection<Item> item)
        {
            Items = (List<Item>) Items.Concat(item);
            Created = DateTime.Now;
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
                Fulfilled = DateTime.Now;
                return true;
            }
            return false;
        }

        /**
         * Returns true if this order has been completed
         */
        public bool IsFulfilled()
        {
            return Fulfilled.HasValue;
        }
    }
}
