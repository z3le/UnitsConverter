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
        /// <returns>meters</returns>
        public static decimal ConvertCentimetersToMeters(decimal centimeters)
        {
            return CommonUtils.UnitsDivision(centimeters, 100);
        }

        /// <summary>
        /// Converts kilometers to miles.
        /// </summary>
        /// <param name="kilometers"> kilometers.</param>
        /// <returns>miles</returns>
        public static decimal ConvertKilometersToMiles(decimal kilometers)
        {
            return CommonUtils.UnitsMultiplication(kilometers, 0.621371M);
        }

        #region Miles
        /// <summary>
        /// Converts the miles to meters.
        /// </summary>
        /// <param name="miles">The miles.</param>
        /// <returns>meters</returns>
        public static decimal ConvertMilesToMeters(decimal miles)
        {
            return CommonUtils.UnitsDivision(miles, 0.00062137M);
        }

        /// <summary>
        /// Converts the miles to kilometers.
        /// </summary>
        /// <param name="miles">The miles.</param>
        /// <returns></returns>
        public static decimal ConvertMilesToKilometers(decimal miles)
        {
            return CommonUtils.UnitsDivision(miles, 0.62137M);
        }

        /// <summary>
        /// Converts the miles to feet.
        /// </summary>
        /// <param name="miles">The miles.</param>
        /// <returns></returns>
        public static decimal ConvertMilesToFeet(decimal miles)
        {
            return CommonUtils.UnitsMultiplication(miles, 5280M);
        }
        #endregion
    }
}
