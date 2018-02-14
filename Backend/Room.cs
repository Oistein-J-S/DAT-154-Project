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
        int Size { get; set; }
                //make ENUM?
        public List<Issue> Issues { get; }
        public List<Order> Orders { get; }

        public Room(int roomNumber, int bedCount, int size)
        {
            RoomNumber = roomNumber;
            BedCount = bedCount;
            Size = size;
            Inhabited = false;
            LastCleaned = new DateTime(1970, 1, 1);
        }
        public void RaiseIssue(Issue issue)
        {
            Issues.Add(Issue issue);
        }
        public void CompleteIssue(Issue issue)
        {
            Issues.Remove(Issue issue);
        }
        public void Clean()
        {
            LastCleaned = DateTime.Today;
        }
        public bool NeedsCleaning()
        {
            return DateTime.Today == LastCleaned;
        }


        //Front desk check-in / check-out controls this
        public bool Inhabited { get; set; }
        //Cleaner sets this on completed task
        DateTime LastCleaned { get; set; }

}
}
