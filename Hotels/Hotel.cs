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

        private double Round(double nrLikes)
        {
            return (nrLikes > 10000) ? (double)10000 : nrLikes;
        }

        public override double CalculateRating()
        {
            double result = (Round(Likes)/1000 * 0.3 + 2* Stars * 0.7);
            return result;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Number of likes: {0}\n", Likes);
        }
    }
}
