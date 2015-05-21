using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    class GuestHouse : Property
    {
        public int ComfortIndex { get; set; }

        public GuestHouse(string name, string description, string address, int stars, double distanceToCenter, DateTime openingDate,
                            Room[] rooms, int comfortIndex)
            : base(name, description, address, stars, distanceToCenter, openingDate, rooms)
        {
            ComfortIndex = comfortIndex;
        }

        private double Round(double nrLikes)
        {
            return (nrLikes > 10000) ? (double)10000 : nrLikes;
        }

        sealed public override double CalculateRating()
        {
            return ComfortIndex * 0.6 + 2 * (double)Stars * 0.4;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Comfort Index: {0}\n", ComfortIndex);
        }
    }


}
