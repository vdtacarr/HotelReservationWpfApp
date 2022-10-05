using FirstWpfApp.Commands;
using FirstWpfApp.Helper;
using FirstWpfApp.Models;
using FirstWpfApp.Services;
using FirstWpfApp.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FirstWpfApp.ViewModels
{
    public class ReservationListingViewModel:ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
        private readonly Hotel _hotel;
        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ReservationListingViewModel(Hotel hotel, NavigationStore navigationStore)
        {
            _hotel = hotel;
            _reservations = new ObservableCollection<ReservationViewModel>();
           
            MakeReservationCommand = new NavigateCommand<MakeReservationViewModel>(new NavigationService<MakeReservationViewModel>(navigationStore, () => new MakeReservationViewModel(_hotel, navigationStore)));
            CheckedCommand = new CheckedCommand();
            GoDetailCommand = new NavigateCommand<ReservationDetailViewModel>(new NavigationService<ReservationDetailViewModel>(navigationStore, () => new ReservationDetailViewModel(navigationStore, hotel, ReserveStore.GetReservation().Username)));
            UpdateReservations();
        }

        private void UpdateReservations()
        {
            _reservations.Clear();
            foreach (var reservation in _hotel.GetAllReservations())
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation, new NavigationStore());
                _reservations.Add(reservationViewModel);
            }

        }
     
        public ICommand MakeReservationCommand { get; }
        public ICommand GoDetailCommand { get; set; }
        public ICommand CheckedCommand { get; set; }
    }
}
