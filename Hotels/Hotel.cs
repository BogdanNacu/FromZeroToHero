using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    class Hotel
    {
        private string name, description, address;
        private int stars;
        private double distanceToCenter;
        private DateTime openingDate;
        private Room[] rooms;
        static protected string distanceMeasurementUnit;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 50)
                {
                    Console.WriteLine("Max name length is 50 characters!");
                    name = null;
                }
                else
                    name = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (value.Length > 500)
                {
                    Console.WriteLine("Max description length is 500 characters!");
                    description = null;
                }
                else
                    description = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (value.Length > 100)
                {
                    Console.WriteLine("Max address length is 100 characters!");
                    address = null;
                }
                else
                    address = value;
            }
        }

        public int Stars
        {
            get { return stars; }
            set
            {
                if (value < 0 || value > 5)
                {
                    Console.WriteLine("Stars: only from 0 to 5!");
                    stars = 0;
                }
                else
                    stars = value;
            }
        }

        public double DistanceToCenter
        {
            get { return distanceToCenter; }
            set
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Distance to center is between 0 to 100!");
                    distanceToCenter = 0;
                }
                else
                    distanceToCenter = value;
            }
        }

        public DateTime OpeningDate
        {
            get { return openingDate; }
            set
            {
                if (value > DateTime.Now || value < new DateTime(1800, 1, 1))
                {
                    Console.WriteLine("Max name length is 50 characters!");
                    openingDate = new DateTime();
                }
                else
                    openingDate = value;
            }
        }

        public Room[] Rooms
        {
            get { return rooms; }
            set
            {
                rooms = value;
            }
        }

        static Hotel()
        {
            distanceMeasurementUnit = "Miles";
        }

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

        public static void SetDistanceMeasurementUnit(string measurementUnit)
        {
            distanceMeasurementUnit = measurementUnit;
        }

        public static string GetDistanceMeasurementUnit()
        {
            return distanceMeasurementUnit;
        }

        public double GetDistanceToCenterInUnits(string measurementUnit)
        {
            if (distanceMeasurementUnit.Equals(measurementUnit))
                return distanceToCenter;
            else
                if (measurementUnit.Equals("Km"))
                    return DistanceMeasurementConverter.TransformMilesToKilometers(distanceToCenter);
                else
                    if (measurementUnit.Equals("Miles"))
                        return DistanceMeasurementConverter.TransformKilometersToMiles(distanceToCenter);
            return -1;
        }

        public void DisplayInfo()
        {
            //---Alternative to hotel display info:
            //Console.Write("Hotel {0} at {1} opened {2} and has {3} rooms.", name, address, openingDate, rooms.Length);
            //Console.Write("It is rated {0} stars");
            //Console.WriteLine(" Hotel description: " + description);
            //---

            Console.Write("Hotel Name: {0}\n Description: {1}\n Address: {2}\n Stars: {3}\n", name, description, address, stars);
            Console.WriteLine(" Distance to center: {0} {1}", distanceToCenter, distanceMeasurementUnit);

            Console.WriteLine(" Opening date: {1}\n\n Rooms: ", distanceToCenter, openingDate);
            for (int i = 0; i < rooms.Length; i++ )
            {
                Console.WriteLine("Room {0}:", i);
                rooms[i].DisplayInfo();
            }
        }
    }
}
