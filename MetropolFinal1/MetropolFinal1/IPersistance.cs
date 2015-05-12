using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetropolFinal1.Model;

namespace MetropolFinal1
{
    public static interface IPersistance
    {
        public string GetLoginData(string LoginName);
        public List<Room> GetRooms(DateTime StartTime);
        public List<TimeSlots> GetTimeSlots(int RoomID, DateTime StartTime);
        public void AddNewBooking(int StudentID, DateTime StartTime, int Length, int RoomID, string BookingTitle, string Description);
        public List<Booking> GetBookings(int StudentID);
        public List<Student> GetStudents(int StudentID); //CONTACTS




    }
}
