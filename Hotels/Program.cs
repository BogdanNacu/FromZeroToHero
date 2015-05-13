using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("This is room1.", 3, 2, RoomTypes.Single);
            Room room2 = new Room("This is room2.", 10, 5, RoomTypes.KingBedroom);

            Hotel hotel = new Hotel("Freedom", "Pretty sweet.", "Bld. Independentei, nr. 3", 5, 12.3, new DateTime(1990, 12, 1), new Room[] { room1, room2 });


            //room1.DisplayInfo();
            //room2.DisplayInfo();
            hotel.DisplayInfo();
        }
    }
}
