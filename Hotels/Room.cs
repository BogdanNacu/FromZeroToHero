using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    enum RoomTypes
    {
        Single,
        Double,
        Twin,
        Duplex,
        KingBedroom
    }

    class Room
    {
        public string description;
        public int number, floor;
        public RoomTypes type;

        public Room(string description, int number, int floor, RoomTypes type)
        {
            this.description = description;
            this.number = number;
            this.floor = floor;
            this.type = type;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Floor: {0}\nNumber of guests: {1}\nDescription: {2}\nRoom Type: {3}\n", floor, number, description, type);
        }
    }
}
