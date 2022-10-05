using FirstWpfApp.Commands;
using FirstWpfApp.Models;
using FirstWpfApp.Services;
using FirstWpfApp.Stores;
using System;
using System.Windows.Input;

namespace FirstWpfApp.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;

        public string RoomID  =>  ""+_reservation.RoomID.FloorNumber + "-"+ _reservation.RoomID.RoomNumber;
        public string StartDate => _reservation.StartTime.ToString("d");
        public string EndDate  => _reservation.EndTime.ToString("d");
        public string Username  => _reservation.Username;

        public ReservationViewModel(Reservation reservation, NavigationStore navigationStore)
        {
            _reservation = reservation;
        }

    }
}
