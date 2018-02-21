using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Suite : Room
    {
        const int ROOM_SZ = 50;
        //public Suite(int roomNumber, int bedCount) : base(roomNumber, bedCount, ROOM_SZ) { }
        public Suite(int roomNumber, int bedCount) : base(roomNumber, bedCount) { }
    }
}
