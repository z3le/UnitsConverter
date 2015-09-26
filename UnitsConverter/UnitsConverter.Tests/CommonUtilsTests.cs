using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class CommonUtilsTests
    {
        [TestMethod]
        public void CommonUtilsTests_UnitsDivision_Success()
        {
            decimal result = CommonUtils.UnitsDivision(256, 2);

            Assert.AreEqual(result, 128);
        }

        [TestMethod]
        public void CommonUtilsTests_UnitsDivision_TestWithNegativeDivident()
        {
            decimal result = CommonUtils.UnitsDivision(-256, 2);

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void CommonUtilsTests_UnitsDivision_TestWithNegativeDivisor()
        {
            decimal result = CommonUtils.UnitsDivision(256, -2);

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void CommonUtilsTests_UnitsDivision_TestWithZeroDivisor()
        {
            decimal result = CommonUtils.UnitsDivision(256, 0);

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void CommonUtilsTests_UnitsMultiplication_Success()
        {
            decimal result = CommonUtils.UnitsMultiplication(128, 2);

            Assert.AreEqual(result, 256);
        }

        [TestMethod]
        public void CommonUtilsTests_UnitsMultiplication_TestWithNegativeUnit()
        {
            decimal result = CommonUtils.UnitsMultiplication(-128, 2);

            Assert.AreEqual(result, 0);
        }
    }
}
