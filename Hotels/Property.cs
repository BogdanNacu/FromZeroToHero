﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    class Property
    {
        private string name, description;
        protected string address;
        private int stars;
        private double distanceToCenter;
        private DateTime openingDate;
        private Room[] rooms;
        static protected string distanceMeasurementUnit;

        #region Properties
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
                if (ValidateStars(value))
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
                if (ValidateDistanceToCenter(value))
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
                if (ValidateDate(value))
                {
                    Console.WriteLine("Wrong Date!");
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

        public bool HasIndoorPool { get; set; }
        public bool HasFreeWiFi { get; set; }
        #endregion

        private static bool ValidateDistanceToCenter(double value)
        {
            return value > 100 || value < 0;
        }

        private bool ValidateDate(DateTime value)
        {
            return value > DateTime.Now || value < new DateTime(1800, 1, 1);
        }

        private static bool ValidateStars(int value)
        {
            return value < 0 || value > 5;
        }

        static Property()
        {
            distanceMeasurementUnit = "Miles";
        }

        public Property()
        {

        }

        public Property(string name, string description, string address, int stars, double distanceToCenter, DateTime openingDate, Room[] rooms)
        {
            this.Name = name;
            this.Description = description;
            this.Address = address;
            this.Stars = stars;
            this.distanceToCenter = distanceToCenter;
            this.OpeningDate = openingDate;
            this.Rooms = rooms;
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
            if (measurementUnit.Equals("Km"))
                return DistanceMeasurementConverter.TransformMilesToKilometers(distanceToCenter);
            if (measurementUnit.Equals("Miles"))
                return DistanceMeasurementConverter.TransformKilometersToMiles(distanceToCenter);
            return -1;
        }

        public virtual double CalculateRating()
        {
            return 2 * Stars;
        }

        public virtual void DisplayInfo()
        {
            //---Alternative to hotel display info:
            //Console.Write("Hotel {0} at {1} opened {2} and has {3} rooms.", name, address, openingDate, rooms.Length);
            //Console.Write("It is rated {0} stars");
            //Console.WriteLine(" Hotel description: ..." + description);
            //---

            Console.Write("Hotel Name: {0}\n Description: {1}\n Address: {2}\n Stars: {3}\n", Name, Description, Address, Stars);
            Console.WriteLine(" Distance to center: {0} {1}", DistanceToCenter, distanceMeasurementUnit);

            Console.WriteLine(" Opening date: {1}\n\n Rooms: ", DistanceToCenter, OpeningDate);
            for (int i = 0; i < rooms.Length; i++)
            {
                Console.WriteLine("Room {0}:", i);
                rooms[i].DisplayInfo();
            }
        }
    }
}
