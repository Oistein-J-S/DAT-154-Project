using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Room
    {
        int RoomNumber { get; set; }
        int BedCount { get; set; }
        //make ENUM?
        public List<Issue> Issues { get; }
        public List<Order> Orders { get; }
        DateTime LastCleaned { get; set; }
        //Front desk check-in / check-out controls this
        //public bool Inhabited { get; set; } // Conflicts with Orders checked in

        public Room(int roomNumber, int bedCount)
        {
            RoomNumber = roomNumber;
            BedCount = bedCount;
            LastCleaned = new DateTime(1970, 1, 1);
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
