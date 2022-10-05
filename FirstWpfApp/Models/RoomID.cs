using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWpfApp.Models
{
    public class RoomID
    {
        public int FloorNumber{ get;  }
        public int RoomNumber { get;  }
        public RoomID(int flooerNumber, int roomNumber)
        {
            FloorNumber = flooerNumber; RoomNumber = roomNumber; 

        }
        public override bool Equals(object? obj)
        {
            return obj is RoomID other &&
                FloorNumber == other.FloorNumber &&
                RoomNumber == other.RoomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);   
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }
    }
}
