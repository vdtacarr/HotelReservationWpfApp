using FirstWpfApp.Models;
using FirstWpfApp.Services;
using FirstWpfApp.Stores;
using FirstWpfApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWpfApp.Commands
{
    public class ReservationDetailCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        private readonly NavigationService<TViewModel> _navigationService;
        public ReservationDetailCommand(NavigationService<TViewModel> navigationService)
        {
            _navigationService = navigationService;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();
        }
       
    }
}
