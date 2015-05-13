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
            Room room1 = new Room();
            room1.description = "This is room1.";
            room1.floor = 2;
            room1.number = 3;
            room1.type = RoomTypes.Single;

            Room room2 = new Room();
            room2.description = "This is room2.";
            room2.floor = 5;
            room2.number = 10;
            room2.type = RoomTypes.KingBedroom;

            Hotel hotel = new Hotel();
            hotel.address = "Bld. Independentei, nr. 3";
            hotel.description = "Pretty sweet.";
            hotel.distanceToCenter = 12.3;
            hotel.name = "Freedom";
            hotel.openingDate = new DateTime(1990, 12, 1);
            hotel.rooms = new Room[] { room1, room2 };
            hotel.stars = 5;

            //Console.Write("Hotel {0} at {1} opened {2} and has {3} rooms.", hotel.name, hotel.address, hotel.openingDate, hotel.rooms.Length);
            //Console.WriteLine(" Hotel description: " + hotel.description);

            //room1.DisplayInfo();
            //room2.DisplayInfo();
            hotel.DisplayInfo();
        }
    }
}
