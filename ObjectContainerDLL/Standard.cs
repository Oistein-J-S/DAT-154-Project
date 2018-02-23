using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    public class Standard : Room
    {
        const int ROOM_SZ = 14;
        public Standard(int roomNumber, int bedCount) : base(roomNumber, bedCount) { }
    }
}
