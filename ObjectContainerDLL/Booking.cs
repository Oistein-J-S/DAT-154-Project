using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    /**
     * A booking is stored in a room and represents a customers reservation of a room.
     * Each booking handles the customer and the customers room service requests
     */
    public class Booking
    {

        //Properties
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }
        public Customer Customer { get; set; }
        public int Balance { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool CheckedIn { get; set; }
        public bool CheckedOut { get; set; }
        public ICollection<Order> Orders { get; set; }


        public Booking(int bookingID, Customer customer, DateTime dateFrom, DateTime dateTo)
        {
            BookingId = bookingID;
            Customer = customer;
            DateFrom = dateFrom;
            DateTo = dateTo;
            Balance = 0;
            CheckedIn = false;
            CheckedOut = false;
            Orders = new List<Order>();
        }

        // Creates a new romservice item
        public void OrderRoomService(List<string> items, int cost)
        {
            Orders.Add(new Order(items, cost));
        }

        public List<Order> getActiveService()
        {
            List<Order> active = new List<Order>();
            foreach(Order o in Orders)
            {
                if (!o.IsFulfilled())// this request is active
                {
                    active.Add(o);
                }
            }
            return active;
        }

        public bool ChangeDate(DateTime dateFrom, DateTime dateTo)
        {
            if (dateFrom < dateTo)
            {
                DateFrom = dateFrom;
                DateTo = dateTo;
                return true;
            }
            // eroneus dates
            return false;
        } 

        /**
        * Payment. Retruns false if payment did not go through.
        */
        public bool Settle()
        {
            //If payment is OK
            if (Charge(Balance)) { 
                Balance = 0;
                return true;
            }
            // something went wrong
            return false;
        }

        /**
         * Checkin, returns fase if not inside reservation time.
         */
        public bool CheckIn()
        {
            if (DateTime.Now >= DateFrom && DateTime.Now <= DateTo) //Within reservation time
            {
                CheckedIn = true;
                return true;
            }
            // something is not right
            return false;
        }

        /**
         * Checkout, NB does not return annything if failed
         */
        public void CheckOut()
        {
            foreach (Order o in Orders) {
                if (o.IsFulfilled()) {// If order has been delivered
                    Balance += o.Total;
                        }
            }
            if (Settle())
            {
                CheckedOut = true;
            }
        }

        /**
         * Checks if the booking dates overlaps
         * @ param Booking
         * @ returns: true if they do
         * false otherwise
         */
        public bool overlaps(Booking booking)
        {
            if ((DateFrom <= booking.DateFrom && DateTo > booking.DateFrom))// if from is within this reservation 
            {
                return true;
            }
            else if (DateFrom < booking.DateTo || DateTo >= booking.DateTo) //or if to is within this reservation
            {
                return true;
            }
            else if (DateFrom >= booking.DateFrom || DateTo <= booking.DateTo) // or if the reservation in it's entirety is within the new reservation
            {
                return true;
            }
            //there is no overlap
            return false;
        }

        // Method for payment
        private bool Charge(int sum)
        {
            // Payment code goes here
            return true;// Assume payment goes through
        }
    }
}
