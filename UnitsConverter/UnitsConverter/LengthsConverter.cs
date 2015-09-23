using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsConverter
{
    /// <summary>
    /// Lenghts converter class
    /// </summary>
    public class LengthsConverter
    {
        /// <summary>
        /// Converts the centimeters to meters.
        /// </summary>
        /// <param name="centimeters">The centimeters.</param>
        /// <returns></returns>
        public static decimal ConvertCentimetersToMeters(decimal centimeters)
        {
            return centimeters / 100M;
        }

        /// <summary>
        /// Converts kilometers to miles.
        /// </summary>
        /// <param name="kilometers"> kilometers.</param>
        /// <returns>miles</returns>
        public static decimal ConvertKilometersToMiles(decimal kilometers)
        {
            return kilometers * 0.621371M;
        }
    }
}
