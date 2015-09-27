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

        #region Convert Kilometers
        /// <summary>
        /// Converts kilometers to miles.
        /// </summary>
        /// <param name="kilometers"> kilometers.</param>
        /// <returns>miles</returns>
        public static decimal ConvertKilometersToMiles(decimal kilometers)
        {
            return CommonUtils.UnitsMultiplication(kilometers, 0.621371M);
        }

        /// <summary>
        /// Converts the kilometers to meters.
        /// </summary>
        /// <param name="kilometers">The kilometers.</param>
        /// <returns></returns>
        public static decimal ConvertKilometersToMeters(decimal kilometers)
        {
            return CommonUtils.UnitsMultiplication(kilometers, 1000);
        }

        /// <summary>
        /// Converts the kilometers to feet.
        /// </summary>
        /// <param name="kilometers">The kilometers.</param>
        /// <returns></returns>
        public static decimal ConvertKilometersToFeet(decimal kilometers)
        {
            return CommonUtils.UnitsMultiplication(kilometers, 3280.84M);
        }

        /// <summary>
        /// Converts the kilometers to inches.
        /// </summary>
        /// <param name="kilometers">The kilometers.</param>
        /// <returns></returns>
        public static decimal ConvertKilometersToInches(decimal kilometers)
        {
            return CommonUtils.UnitsMultiplication(kilometers, 39370.1M);
        }

        /// <summary>
        /// Converts the kilometers to yards.
        /// </summary>
        /// <param name="kilometers">The kilometers.</param>
        /// <returns></returns>
        public static decimal ConvertKilometersToYards(decimal kilometers)
        {
            return CommonUtils.UnitsMultiplication(kilometers, 1093.61M);
        }
        #endregion

        #region Convert Miles
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

        /// <summary>
        /// Converts the miles to inches.
        /// </summary>
        /// <param name="miles">The miles.</param>
        /// <returns></returns>
        public static decimal ConvertMilesToInches(decimal miles)
        {
            return CommonUtils.UnitsMultiplication(miles, 63360);
        }

        /// <summary>
        /// Converts the miles to yards.
        /// </summary>
        /// <param name="miles">The miles.</param>
        /// <returns></returns>
        public static decimal ConvertMilesToYards(decimal miles)
        {
            return CommonUtils.UnitsMultiplication(miles, 1760);
        }

        /// <summary>
        /// Converts the miles to nautical miles.
        /// </summary>
        /// <param name="miles">The miles.</param>
        /// <returns></returns>
        public static decimal ConvertMilesToNauticalMiles(decimal miles)
        {
            return CommonUtils.UnitsMultiplication(miles, 0.86898M);
        }

        /// <summary>
        /// Converts the miles to furlongs.
        /// </summary>
        /// <param name="miles">The miles.</param>
        /// <returns></returns>
        public static decimal ConvertMilesToFurlongs(decimal miles)
        {
            return CommonUtils.UnitsMultiplication(miles, 8);
        }

        /// <summary>
        /// Converts the miles to chains.
        /// </summary>
        /// <param name="miles">The miles.</param>
        /// <returns></returns>
        public static decimal ConvertMilesToChains(decimal miles)
        {
            return CommonUtils.UnitsMultiplication(miles, 80);
        }

        /// <summary>
        /// Converts the miles to us leagues.
        /// </summary>
        /// <param name="miles">The miles.</param>
        /// <returns></returns>
        public static decimal ConvertMilesToUSLeagues(decimal miles)
        {
            return CommonUtils.UnitsMultiplication(miles, 0.33333M);
        }

        /// <summary>
        /// Converts the miles to nautical leagues.
        /// </summary>
        /// <param name="miles">The miles.</param>
        /// <returns></returns>
        public static decimal ConvertMilesToNauticalLeagues(decimal miles)
        {
            return CommonUtils.UnitsMultiplication(miles, 0.28966M);
        }
        #endregion
    }
}
