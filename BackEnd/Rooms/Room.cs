using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Room
    {
        int RoomNumber { get; set; } //make ENUM?
        int BedCount { get; set; } //make ENUM?

        List<Order> Orders { get; }
        List<Issue> Issues { get; } //Maintenance issues
        //TODO Room Scervice items

        DateTime LastCleaned { get; set; }

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
