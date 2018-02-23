using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    public abstract class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int RoomNumber { get; set; } //make ENUM?
        public int BedCount { get; set; } //make ENUM?
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Issue> Issues { get; set; } //Maintenance issues
        public DateTime LastCleaned { get; set; }


        public Room(int roomNumber, int bedCount)
        {
            RoomNumber = roomNumber;
            BedCount = bedCount;
            LastCleaned = new DateTime(1970, 1, 1);
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
            LastCleaned = DateTime.Today;
        }
        public bool NeedsCleaning()
        {
            return DateTime.Today == LastCleaned;
        }
}
}
