using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWpfApp.Models
{
    public class Reservation
    {
        public RoomID?  RoomID { get; set; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public string Username { get; set; }
        public TimeSpan Length => EndTime.Subtract(StartTime);

        public Reservation(RoomID? roomID, string username, DateTime startime, DateTime endTime)
        {
            RoomID = roomID;
            StartTime = startime;
           Username = username;
            EndTime = endTime;
        }

        public bool Conflicts(Reservation reservation)
        {
            if (reservation.RoomID != null)
            {
                return false;
            }
            return reservation.StartTime < EndTime || reservation.EndTime > StartTime;
        }
    }
}
