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
        #region Convert Centimeters

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
        /// Converts the centimeters to millimeters.
        /// </summary>
        /// <param name="centimeters">The centimeters.</param>
        /// <returns></returns>
        public static decimal ConvertCentimetersToMillimeters(decimal centimeters)
        {
            return CommonUtils.UnitsMultiplication(centimeters, 10);
        }

        /// <summary>
        /// Converts the centimeters to feet.
        /// </summary>
        /// <param name="centimeters">The centimeters.</param>
        /// <returns></returns>
        public static decimal ConvertCentimetersToFeet(decimal centimeters)
        {
            return CommonUtils.UnitsMultiplication(centimeters, 0.0328084M);
        }

        /// <summary>
        /// Converts the centimeters to inches.
        /// </summary>
        /// <param name="centimeters">The centimeters.</param>
        /// <returns></returns>
        public static decimal ConvertCentimetersToInches(decimal centimeters)
        {
            return CommonUtils.UnitsMultiplication(centimeters, 0.393701M);
        }

        public static decimal ConvertCentimetersToMicrometers(decimal centimeters)
        {
            return CommonUtils.UnitsMultiplication(centimeters, 10000);
        }

        #endregion

        #region Convert Meters

        /// <summary>
        /// Converts the meters to kilometers.
        /// </summary>
        /// <param name="meters">The meters.</param>
        /// <returns></returns>
        public static decimal ConvertMetersToKilometers(decimal meters)
        {
            return CommonUtils.UnitsDivision(meters, 1000);
        }

        /// <summary>
        /// Converts the meters to miles.
        /// </summary>
        /// <param name="meters">The meters.</param>
        /// <returns></returns>
        public static decimal ConvertMetersToMiles(decimal meters)
        {
            return CommonUtils.UnitsMultiplication(meters, 0.000621371M);
        }

        /// <summary>
        /// Converts the meters to centimeters.
        /// </summary>
        /// <param name="meters">The meters.</param>
        /// <returns></returns>
        public static decimal ConvertMetersToCentimeters(decimal meters)
        {
            return CommonUtils.UnitsMultiplication(meters, 100);
        }

        /// <summary>
        /// Converts the meters to millimeters.
        /// </summary>
        /// <param name="meters">The meters.</param>
        /// <returns></returns>
        public static decimal ConvertMetersToMillimeters(decimal meters)
        {
            return CommonUtils.UnitsMultiplication(meters, 1000);
        }

        /// <summary>
        /// Converts the meters to feet.
        /// </summary>
        /// <param name="meters">The meters.</param>
        /// <returns></returns>
        public static decimal ConvertMetersToFeet(decimal meters)
        {
            return CommonUtils.UnitsMultiplication(meters, 3.28084M);
        }

        /// <summary>
        /// Converts the meters to inches.
        /// </summary>
        /// <param name="meters">The meters.</param>
        /// <returns></returns>
        public static decimal ConvertMetersToInches(decimal meters)
        {
            return CommonUtils.UnitsMultiplication(meters, 39.3701M);
        }

        /// <summary>
        /// Converts the meters to yards.
        /// </summary>
        /// <param name="meters">The meters.</param>
        /// <returns></returns>
        public static decimal ConvertMetersToYards(decimal meters)
        {
            return CommonUtils.UnitsMultiplication(meters, 1.09361M);
        }

        /// <summary>
        /// Converts the meters to decimeters.
        /// </summary>
        /// <param name="meters">The meters.</param>
        /// <returns></returns>
        public static decimal ConvertMetersToDecimeters(decimal meters)
        {
            return CommonUtils.UnitsMultiplication(meters, 10);
        }

        #endregion

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

        #region Convert Feet

        public static decimal ConvertFeetToMiles(decimal feet)
        {
            return CommonUtils.UnitsMultiplication(feet, 0.000189394M);
        }

        #endregion
    }
}
