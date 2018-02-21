using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Cleaning : Employee
    {
        public Cleaning(string firstName, string lastName, string ssn) : base(firstName, lastName, ssn)
        {

        }
        public void StartCleaning(Room room) { }
        public void FinishCleaning(Room room) { }

        //public List<Room> GetDirtyRooms() {}
    }
}
