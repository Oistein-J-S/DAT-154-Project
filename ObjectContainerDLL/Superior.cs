using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContainerDLL
{
    public class Superior : Room
    {
        const int ROOM_SZ = 25;
        public Superior(int roomNumber, int bedCount) : base(roomNumber, bedCount) { }
    }
}
