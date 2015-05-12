using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetropolFinal1.Model;

namespace MetropolFinal1.DAL
{
    public static class Persistance: IPersistance
    {

        #region FAKEDATABASE
        public static List<Room> Rooms;


        #endregion

        private string GetLoginData(string LoginName)
        {
            throw new NotImplementedException();
        }

        public static List<Model.Room> GetRooms(DateTime StartTime)
        {
            return Rooms;
        }

        public List<Model.TimeSlots> GetTimeSlots(int RoomID, DateTime StartTime)
        {
            throw new NotImplementedException();
        }

        public void AddNewBooking(int StudentID, DateTime StartTime, int Length, int RoomID, string BookingTitle, string Description)
        {
            throw new NotImplementedException();
        }

        public List<Model.Booking> GetBookings(int StudentID)
        {
            throw new NotImplementedException();
        }

        public List<Model.Student> GetStudents(int StudentID)
        {
            throw new NotImplementedException();
        }

        void Persistance()
        {
            Rooms = new List<Room>() 
            {
                new Room{RommID = 1, NumOfSeats = 20, OtherFacilities = "", Projector = true, WhiteBoard = false},
                new Room{RommID = 2, NumOfSeats = 22, OtherFacilities = "", Projector = true, WhiteBoard = false},
                new Room{RommID = 3, NumOfSeats = 25, OtherFacilities = "", Projector = true, WhiteBoard = false},
                new Room{RommID = 4, NumOfSeats = 230, OtherFacilities = "", Projector = true, WhiteBoard = false}
            };

        }
    }
}
