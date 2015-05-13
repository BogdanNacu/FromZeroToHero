using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotels
{
    static class DistanceMeasurementConverter
    {
        static public double TransformMilesToKilometers(double miles)
        {
            return miles * 1.609;
        }

        static public double TransformKilometersToMiles(double kilometers)
        {
            return kilometers / 1.609;
        }
    }
}
