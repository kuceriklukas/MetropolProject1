using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetropolFinal1.Model
{
    class TimeSlots
    {
        private int startTime;

        public int StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        private int endTime;

        public int EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }


        private bool availability;

        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }
    }
}
