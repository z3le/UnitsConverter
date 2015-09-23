using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsConverterTests
    {
        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToMeters_Succes()
        {
            decimal centimeters = 20;
            decimal meters = LengthsConverter.ConvertCentimetersToMeters(centimeters);

            Assert.AreEqual(meters, 0.2M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToMiles_Succes()
        {
            decimal kilometers = 15M;
            decimal meters = LengthsConverter.ConvertKilometersToMiles(kilometers);

            Assert.AreEqual(meters, 9.320565M);
        }
    }
}
