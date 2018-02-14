using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class Standard : Room
    {
        const int ROOM_SZ = 14;
        public Standard(int roomNumber, int bedCount) : base(roomNumber, bedCount, ROOM_SZ) { }
    }
}

}
