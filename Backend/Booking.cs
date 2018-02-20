using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Booking
    {
        int BookingId { get; set; }
        Customer Customer { get; set; }
        int Balance { get; set; }
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }
        Room Room { get; set; }
        bool CheckedIn;
        bool CheckedOut;

        public Booking(int bookingId, Customer customer, DateTime dateFrom, DateTime dateTo, Room room)
        {
            BookingId = bookingId;
            Customer = customer;
            DateFrom = dateFrom;
            DateTo = dateTo;
            Room = room;
            Balance = 0;
            CheckedIn = false;
            CheckedOut = false;

        }

        public void ChargeRoom(int amount)
        {
            Balance += amount;
        }
        public void Settle()
        {
            //If payment is OK
            if (Charge()) { 
            Balance = 0;
            }
        }
        public bool Charge()
        {
            //Will not be implemented
            return true;
        }
        public void CheckIn()
        {
            Room.Inhabited = true;
            CheckedIn = true;
        }

        public void CheckOut()
        {
            foreach (Order o in Room.Orders) {
                if (o.Fulfilled > new DateTime(1970,1,1)) {
                    Balance += o.Total;
                        }
            }
            Settle();
            CheckedOut = true;
        }
    }
}
