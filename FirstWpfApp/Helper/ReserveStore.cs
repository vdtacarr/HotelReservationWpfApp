using FirstWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWpfApp.Helper
{
    public static class ReserveStore
    {
        static Reservation _reservation { get; set; }

        public static void SetReservation(Reservation reservation)
        {
            _reservation = reservation;
        }
        public static Reservation GetReservation()
        {
            return _reservation;
        }
    }
}
