using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetropolFinal1.View;
using MetropolFinal1.Model;
using MetropolFinal1.Common;

namespace MetropolFinal1.ViewModel
{
    class MenuVM
    {
        public RelayCommand NavigateToBookingCommand;

        void MenuVM()
        {
            NavigateToBookingCommand = new RelayCommand(NavigateToBooking);
        }

        public void NavigateToBooking()
        {
            
        }
    }
}
