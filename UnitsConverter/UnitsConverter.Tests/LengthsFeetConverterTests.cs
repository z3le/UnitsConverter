using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsFeetConverterTests
    {
        public decimal result = 0;

        [TestMethod]
        public void LenghtsConverter_ConvertFeetToMiles_Succes()
        {
            result = LengthsConverter.ConvertFeetToMiles(2000);

            Assert.AreEqual(result, 0.378788000M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertFeetToKilometers_Succes()
        {
            result = LengthsConverter.ConvertFeetToKilometers(2000);

            Assert.AreEqual(result, 0.6096M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertFeetToMeters_Succes()
        {
            result = LengthsConverter.ConvertFeetToMeters(20);

            Assert.AreEqual(result, 6.096M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertFeetToInches_Succes()
        {
            result = LengthsConverter.ConvertFeetToInches(20);

            Assert.AreEqual(result, 240);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertFeetToCentimeters_Succes()
        {
            result = LengthsConverter.ConvertFeetToCentimeters(20);

            Assert.AreEqual(result, 609.6M);
        }
    }
}
