﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Superior : Room
{
    const int ROOM_SZ = 25;
        //public Superior(int roomNumber, int bedCount) : base(roomNumber, bedCount, ROOM_SZ) { }
        public Superior(int roomNumber, int bedCount) : base(roomNumber, bedCount) { }
    }
}