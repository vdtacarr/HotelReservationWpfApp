using FirstWpfApp.Models;
using FirstWpfApp.Services;
using FirstWpfApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FirstWpfApp.Commands
{
    public class MakeReservationCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        private readonly Hotel _hotel;
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly NavigationService<TViewModel> _reservationViewNavigationService;
        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel,  Hotel hotel, NavigationService<TViewModel> reservationViewNavigationService)
        {
            _hotel = hotel;
            _makeReservationViewModel = makeReservationViewModel;
            _reservationViewNavigationService = reservationViewNavigationService;   
            _makeReservationViewModel.PropertyChanged += _makeReservationViewModel_PropertyChanged; 
        }

        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(new RoomID(_makeReservationViewModel.FloorNo, _makeReservationViewModel.RoomNo), _makeReservationViewModel.Username, _makeReservationViewModel.StartDate,_makeReservationViewModel.EndDate);
            try
            {
                _hotel.MakeReservation(reservation);

                MessageBox.Show("Successfully reserved room","Success", MessageBoxButton.OK, MessageBoxImage.Information);
                _reservationViewNavigationService.Navigate();
            }
            catch 
            {
                MessageBox.Show("This room is already taken", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) && _makeReservationViewModel?.FloorNo > 0 && base.CanExecute(parameter);  
        }

        private void _makeReservationViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeReservationViewModel.Username) || e.PropertyName == nameof(MakeReservationViewModel.FloorNo))
            {
                OnCanExecuteChanged();
            }
        }
    }
}
