using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsKilometersConverterTests
    {
        public decimal result = 0;

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToMiles_Succes()
        {
            result = LengthsConverter.ConvertKilometersToMiles(15);

            Assert.AreEqual(result, 9.320565M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToMeters_Succes()
        {
            result = LengthsConverter.ConvertKilometersToMeters(15);

            Assert.AreEqual(result, 15000);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToFeet_Succes()
        {
            result = LengthsConverter.ConvertKilometersToFeet(15);

            Assert.AreEqual(result, 49212.6M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToInches_Succes()
        {
            result = LengthsConverter.ConvertKilometersToInches(15);

            Assert.AreEqual(result, 590551.5M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToYards_Succes()
        {
            result = LengthsConverter.ConvertKilometersToYards(15);

            Assert.AreEqual(result, 16404.15M);
        }
    }
}
