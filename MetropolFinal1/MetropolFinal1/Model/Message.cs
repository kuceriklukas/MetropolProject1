using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetropolFinal1.Model
{
    class Message
    {
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private DateTime meetingDate;

        public DateTime MeetingDate
        {
            get { return meetingDate; }
            set { meetingDate = value; }
        }

        private string bookingTitle;


        public string BookingTitle
        {
            get { return bookingTitle; }
            set { bookingTitle = value; }
        }

        private string meetingDescription;

        public string MeetingDescription
        {
            get { return meetingDescription; }
            set { meetingDescription = value; }
        }



    }
}
