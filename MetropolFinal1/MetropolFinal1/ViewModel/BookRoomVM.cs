using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetropolFinal1.DAL;

namespace MetropolFinal1.ViewModel
{
    class BookRoomVM
    {
        private int selectedDate;

        public int SelectedDate
        {
            get { return selectedDate; }
            set { selectedDate = value; }
        }

        private int selectedRoom;

        public int SelectedRoom
        {
            get { return selectedRoom; }
            set { selectedRoom = value; }
        }

        private int selectedPeriod;

        public int SelectedPeriod
        {
            get { return selectedPeriod; }
            set { selectedPeriod = value; }
        }


        void ViewModel() 
        {

        }

        private void AddBooking()
        {
        
        }

        private void GetRooms()
        {
            DateTime date = new DateTime(2045, 6, 5);
            Persistance.GetRooms(date);
        }

    }
}
