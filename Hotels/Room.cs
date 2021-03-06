﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    class Room
    {
        private string description;
        private int number, floor;
        private int places;
        private RoomTypes type;

        #region Properties
        public RoomTypes Type
        {
            get { return type; }
            set
            {
                type = value;
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

        public int Number
        {
            get { return number; }
            set
            {
                if (ValidateRoomNumber(value))
                {
                    Console.WriteLine("Stars: only from 0 to 10000!");
                    number = 0;
                }
                else
                    number = value;
            }
        }

        public int Floor
        {
            get { return floor; }
            set
            {
                if (ValidateFloor(value))
                {
                    Console.WriteLine("Floor: only from 0 to 1000!");
                    floor = 0;
                }
                else
                    floor = value;
            }
        }

        private static bool ValidateFloor(int value)
        {
            return value < 0 || value > 1000;
        }

        public int Places
        {
            get { return places; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Places: greater than 0!");
                    places = 0;
                }
                else
                    places = value;
            }
        }

        public bool HasAirConditioning { get; set; }
        public bool HasFlatScreenTV { get; set; }
        #endregion

        public Room(string description, int number, int floor, RoomTypes type)
        {
            this.Description = description;
            this.Number = number;
            this.Floor = floor;
            this.Type = type;
        }

        private static bool ValidateRoomNumber(int value)
        {
            return value < 0 || value > 10000;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Floor: {0}\nNumber of guests: {1}\nDescription: {2}\nRoom Type: {3}\n", Floor, Number, Description, Type);
        }
    }
}
