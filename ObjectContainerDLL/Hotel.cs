using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    public class Hotel
    {
        [Key]
        public string Name { get; set; }
        public string Address { get; set; }
        [ForeignKey("")]
        public ICollection<Room> Rooms { get; set; }

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
