using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsKilometersConverterTests
    {
        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToMiles_Succes()
        {
            decimal miles = LengthsConverter.ConvertKilometersToMiles(15);

            Assert.AreEqual(miles, 9.320565M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToMeters_Succes()
        {
            decimal meters = LengthsConverter.ConvertKilometersToMeters(15);

            Assert.AreEqual(meters, 15000);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToFeet_Succes()
        {
            decimal feet = LengthsConverter.ConvertKilometersToFeet(15);

            Assert.AreEqual(feet, 49212.6M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToInches_Succes()
        {
            decimal inches = LengthsConverter.ConvertKilometersToInches(15);

            Assert.AreEqual(inches, 590551.5M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToYards_Succes()
        {
            decimal yards = LengthsConverter.ConvertKilometersToYards(15);

            Assert.AreEqual(yards, 16404.15M);
        }
    }
}
