using FirstWpfApp.Helper;
using FirstWpfApp.Models;
using FirstWpfApp.Services;
using FirstWpfApp.Stores;
using FirstWpfApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstWpfApp.Views
{
    /// <summary>
    /// Interaction logic for ReservationListingView.xaml
    /// </summary>
    public partial class ReservationListingView : UserControl
    {
        public string userName { get; set; }
        public ReservationListingView() 
        {
             InitializeComponent();
        }

        private void MyCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var reservation = e.Source as FrameworkElement;
            var reser = reservation.DataContext as ReservationViewModel;
            userName = reser.Username;

            ReserveStore.SetReservation(new Reservation(new RoomID(Int32.Parse(reser.RoomID.Split("-")[0]), Int32.Parse(reser.RoomID.Split("-")[1])),userName,DateTime.Parse(reser.StartDate), DateTime.Parse(reser.EndDate)));
        }
       
    }
}
