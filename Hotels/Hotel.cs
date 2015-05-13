using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    class Hotel
    {
        public string name, description, address;
        public int stars;
        public double distanceToCenter;
        public DateTime openingDate;
        public Room[] rooms;

        public void DisplayInfo()
        {
            Console.Write("Hotel Name: {0}\n Description: {1}\n Address: {2}\n Stars: {3}\n", name, description, address, stars);
            Console.WriteLine(" Distance to center: {0}\n Opening date: {1}\n\n Rooms: ", distanceToCenter, openingDate);
            for (int i = 0; i < rooms.Length; i++ )
            {
                Console.WriteLine("Room {0}:", i);
                rooms[i].DisplayInfo();
            }
        }
    }
}
