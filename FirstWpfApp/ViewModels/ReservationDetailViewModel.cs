
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
    public class ReservationDetailViewModel : ViewModelBase
    {
        public string Name => _name;
        private readonly string _name;

        public ReservationDetailViewModel(NavigationStore navigationStore, Hotel hotel, string name)
        {
            _name = name;
            TurnListViewCommand = new NavigateCommand<ReservationListingViewModel>(new NavigationService<ReservationListingViewModel>(navigationStore, () => new ReservationListingViewModel(hotel, navigationStore)));
        }
        public ICommand TurnListViewCommand { get; }
    }
}