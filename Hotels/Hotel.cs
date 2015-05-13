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

        public Hotel(string name, string description, string address, int stars, double distanceToCenter, DateTime openingDate, Room[] rooms)
        {
            this.name = name;
            this.description = description;
            this.address = address;
            this.stars = stars;
            this.distanceToCenter = distanceToCenter;
            this.openingDate = openingDate;
            this.rooms = rooms;
        }

        public void DisplayInfo()
        {
            //---Alternative to hotel display info:
            //Console.Write("Hotel {0} at {1} opened {2} and has {3} rooms.", hotel.name, hotel.address, hotel.openingDate, hotel.rooms.Length);
            //Console.WriteLine(" Hotel description: " + hotel.description);
            //---

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
