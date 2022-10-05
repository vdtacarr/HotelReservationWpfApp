using FirstWpfApp.Commands;
using FirstWpfApp.Models;
using FirstWpfApp.Services;
using FirstWpfApp.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstWpfApp.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        private string username;
        public string Username { get{ return username; } set { username = value; OnPropertyChanged(nameof(Username)); } }   

        private int roomNumber;
        public int RoomNo { get { return roomNumber; } set { roomNumber = value; OnPropertyChanged(nameof(RoomNo)); } }

        private int floorNumber;
        public int FloorNo { get { return floorNumber; } set { floorNumber = value;OnPropertyChanged(nameof(FloorNo)); } }

        private DateTime startDate = new DateTime(2022,1,1);
        public DateTime StartDate { get { return startDate; } set { startDate = value; OnPropertyChanged(nameof(StartDate)); } }

        private DateTime endDate = new DateTime(2022, 1, 1);
        public DateTime EndDate { get { return endDate; } set { endDate = value; OnPropertyChanged(nameof(EndDate)); } } 

        public  ICommand SubmitCommand { get; }
        public  ICommand CancelCommand { get; }

        public MakeReservationViewModel(Hotel hotel, NavigationStore navigationStore)
        {
            SubmitCommand = new MakeReservationCommand<ReservationListingViewModel>(this, hotel, new NavigationService<ReservationListingViewModel>(navigationStore, () => new ReservationListingViewModel(hotel, navigationStore)));

            CancelCommand = new NavigateCommand<ReservationListingViewModel>(new NavigationService<ReservationListingViewModel>(navigationStore,()=> new ReservationListingViewModel(hotel,navigationStore)));
        }
    }
}
