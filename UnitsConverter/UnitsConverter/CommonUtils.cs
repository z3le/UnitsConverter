using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsConverter
{
    public class CommonUtils
    {
        /// <summary>
        /// Uses the division to calculate units.
        /// </summary>
        /// <param name="dividend">The dividend.</param>
        /// <param name="divisor">The divisor.</param>
        /// <returns></returns>
        public static decimal UnitsDivision(decimal dividend, decimal divisor)
        {
            if (dividend < 0 || divisor <= 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        /// <summary>
        /// Uses the multiplication to calculate units.
        /// </summary>
        /// <param name="unitOne">The unit one.</param>
        /// <param name="unitTwo">The unit two.</param>
        /// <returns></returns>
        public static decimal UnitsMultiplication(decimal unitOne, decimal unitTwo)
        {
            if (unitOne < 0 || unitTwo < 0)
            {
                return 0;
            }

            return unitOne * unitTwo;
        }
    }
}
