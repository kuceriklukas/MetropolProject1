﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetropolFinal1.Model
{
    class Room
    {
        private int rommID;

        public int RommID
        {
            get { return rommID; }
            set { rommID = value; }
        }

        private int numOfSeats;

        public int NumOfSeats
        {
            get { return numOfSeats; }
            set { numOfSeats = value; }
        }

        private bool projector;

        public bool Projector
        {
            get { return projector; }
            set { projector = value; }
        }

        private bool whiteBoard;

        public bool WhiteBoard
        {
            get { return whiteBoard; }
            set { whiteBoard = value; }
        }

        private string otherFacilities;

        public string OtherFacilities
        {
            get { return otherFacilities; }
            set { otherFacilities = value; }
        }


    }
}
