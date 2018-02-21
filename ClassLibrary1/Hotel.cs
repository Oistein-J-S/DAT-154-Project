using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Hotel
    {
        private string name;
        private string address;
        private List<Room> rooms;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        internal List<Room> Rooms { get => rooms; set => rooms = value; }

        public Hotel(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public bool AddRoom(Room room)
        {
            if (room.RoomNumber >= 0)
            {
                Rooms.Add(room);
                return true;
            }
            return false;
        }

        public bool DeleteRoom(Room room)
        {
            return Rooms.Remove(room);
        }
    }
}

/**
 * internal List<Room> Rooms
 *  {
 *    get => rooms;
 *    set { rooms = value; }
 *  }
 */
