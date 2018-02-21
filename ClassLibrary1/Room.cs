using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Room
    {
        private int roomNumber; //make ENUM?
        private int bedCount; //make ENUM?
        private List<Booking> bookings;
        private List<Issue> issues; //Maintenance issues
        private DateTime lastCleaned;

        public int RoomNumber{
            get => roomNumber;
            set { if (roomNumber >= 0) {roomNumber = value;} }
        }
        public int BedCount {
            get => bedCount;
            set { if (BedCount >= 0) {bedCount = value;} }
        }
        public List<Booking> Bookings { get => bookings; set => bookings = value; }
        public List<Issue> Issues { get => issues; set => issues = value; }


        public Room(int roomNumber, int bedCount)
        {
            RoomNumber = roomNumber;
            BedCount = bedCount;
            lastCleaned = new DateTime(1970, 1, 1);
        }

        public bool AddBooking(Booking booking)
        {
            // check if anny existing bookings overlap the date of the new booking.
            foreach (Booking b in Bookings)
            {
                if (b.overlaps(booking))
                {
                    //break and return false
                    return false;
                }
            }
            Bookings.Add(booking);
            return true;
        }

        public void RaiseIssue(Issue issue)
        {
            Issues.Add(issue);
        }
        public void CompleteIssue(Issue issue)
        {
            Issues.Remove(issue);
        }
        public void Clean()
        {
            lastCleaned = DateTime.Today;
        }
        public bool NeedsCleaning()
        {
            return DateTime.Today == lastCleaned;
        }
}
}
