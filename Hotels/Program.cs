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
            Property hotel = new Property("Freedom", "Pretty sweet.", "Bld. Independentei, nr. 3", 5, 12.3, new DateTime(1990, 12, 1), new Room[] { room1, room2 });
            Property hotel2 = new Property("SpaceX", "Space themed hotel", "Moon 13", 10, 200, new DateTime(2015, 12, 1), new Room[] { room2 });

            Property.SetDistanceMeasurementUnit("Km");
            Console.WriteLine(Property.GetDistanceMeasurementUnit());
            hotel.DisplayInfo();
            hotel2.DisplayInfo();

            Console.WriteLine("Distance to center: {0} {1}", hotel.DistanceToCenter, Property.GetDistanceMeasurementUnit());
            Console.WriteLine("Distance in miles: {0} Miles\n", hotel.GetDistanceToCenterInUnits("Miles"));

            Property hotel3 = new Property { Name = "Wind", Description = "Feel thye winds.", Address = "Str. Fortuna, nr.2", 
                HasFreeWiFi = true, HasIndoorPool = true, DistanceToCenter = 55.3, OpeningDate = new DateTime(2010,12,5), 
                Stars = 2, Rooms = new Room[] {room1, room2} };
            hotel3.DisplayInfo();
        }
    }
}
