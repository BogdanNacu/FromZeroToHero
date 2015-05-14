using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    sealed class Hotel : Property
    {
        public double Likes { get; set; }

        public Hotel(string name, string description, string address, int stars, double distanceToCenter, DateTime openingDate,
                        Room[] rooms, double likes)
            : base(name, description, address, stars, distanceToCenter, openingDate, rooms)
        {
            Likes = likes;
        }

        public void ChangeAddress(string address)
        {
            this.address = address;
        }
    }
}
