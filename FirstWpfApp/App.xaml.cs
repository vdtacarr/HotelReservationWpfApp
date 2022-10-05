using FirstWpfApp.Models;
using FirstWpfApp.Services;
using FirstWpfApp.Stores;
using FirstWpfApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FirstWpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel hotel;
        private NavigationStore _navigationStore;
        public App()
        {
            _navigationStore = new NavigationStore();

            hotel = new Hotel("Vedat Suites");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new ReservationDetailViewModel(_navigationStore,hotel,"Vedat");
                MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
        //private MakeReservationViewModel CreateMakeReservationViewModel()
        //{
        //    return new MakeReservationViewModel(hotel, new NavigationService(_navigationStore, CreateReservationViewModel));
        //}
        //private ReservationListingViewModel CreateReservationViewModel()
        //{
        //    return new ReservationListingViewModel(hotel, new NavigationService(_navigationStore, CreateMakeReservationViewModel));
        //}
    }
}
