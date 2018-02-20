using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    /**
     * A booking is stored in a room and represents a customers reservation of a room.
     * Each booking handles the customer and the customers room service requests
     */
    class Booking
    {
        int BookingId { get; set; }
        Customer Customer { get; set; }
        int Balance { get; set; }
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }
        bool CheckedIn;
        bool CheckedOut;
        List<Order> Orders;

        public Booking(int bookingId, Customer customer, DateTime dateFrom, DateTime dateTo)
        {
            BookingId = bookingId;
            Customer = customer;
            DateFrom = dateFrom;
            DateTo = dateTo;
            Balance = 0;
            CheckedIn = false;
            CheckedOut = false;

        }

        // TODO Order room service
        // TODO Uppdate a room service order

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

        // Method for payment
        private bool Charge(int sum)
        {
            // Payment code goes here
            return true;// Assume payment goes through
        }
    }
}
