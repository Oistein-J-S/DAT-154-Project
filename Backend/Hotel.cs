using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Hotel
    {
        string Name { get; set; }
        string Address { get; set; }
        List<Room> rooms { get; set }
        public Hotel(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public void DeleteRoom(Room room)
        {
            rooms.Remove(room room);
        }
    }
}
