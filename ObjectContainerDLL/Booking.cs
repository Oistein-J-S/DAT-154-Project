using System;
using System.Collections.Generic;
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
        //Declarations
        private int bookingId;
        private Customer customer;
        private int balance;
        private DateTime dateFrom;
        private DateTime dateTo;
        private bool checkedIn;
        private bool checkedOut;
        private List<Order> orders;

        //Propperties
        public int BookingId { get => bookingId;}
        internal Customer Customer { get => customer; set => customer = value; }
        public int Balance { get => balance; set => balance = value; }
        public DateTime DateFrom { get => dateFrom;}
        public DateTime DateTo { get => dateTo;}
        public bool CheckedIn { get => checkedIn;}
        public bool CheckedOut { get => checkedOut;}
        public List<Order> Orders { get => Orders;}

        public ICollection<Booking> Bookings { get; set; }

        public Booking(int bookingId, Customer customer, DateTime dateFrom, DateTime dateTo)
        {
            this.bookingId = bookingId;
            this.customer = customer;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            balance = 0;
            checkedIn = false;
            checkedOut = false;
            orders = new List<Order>();
        }

        // Creates a new romservice item
        public void OrderRoomService(List<string> items, int cost)
        {
            orders.Add(new Order(items, cost));
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
                this.dateFrom = dateFrom;
                this.dateTo = dateTo;
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
            if (Charge(balance)) { 
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
                checkedIn = true;
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
                checkedOut = true;
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
            if ((dateFrom <= booking.DateFrom && dateTo > booking.DateFrom))// if from is within this reservation 
            {
                return true;
            }
            else if (dateFrom < booking.DateTo || dateTo >= booking.DateTo) //or if to is within this reservation
            {
                return true;
            }
            else if (dateFrom >= booking.DateFrom || dateTo <= booking.DateTo) // or if the reservation in it's entirety is within the new reservation
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
