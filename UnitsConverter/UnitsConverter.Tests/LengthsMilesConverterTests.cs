using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsMilesConverterTests
    {
        public decimal result = 0;

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToMeters_Succes()
        {
            result = LengthsConverter.ConvertMilesToMeters(20);

            Assert.AreEqual(result, 32186.941757728889389574649565M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToKilometers_Succes()
        {
            result = LengthsConverter.ConvertMilesToKilometers(20);

            Assert.AreEqual(result, 32.186941757728889389574649565M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToFeet_Succes()
        {
            result = LengthsConverter.ConvertMilesToFeet(20);

            Assert.AreEqual(result, 105600M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToInches_Succes()
        {
            result = LengthsConverter.ConvertMilesToInches(5);

            Assert.AreEqual(result, 316800);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToYards_Succes()
        {
            result = LengthsConverter.ConvertMilesToYards(5);

            Assert.AreEqual(result, 8800);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToNauticalMiles_Succes()
        {
            result = LengthsConverter.ConvertMilesToNauticalMiles(20);

            Assert.AreEqual(result, 17.37960M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToFurlongs_Succes()
        {
            result = LengthsConverter.ConvertMilesToFurlongs(15);

            Assert.AreEqual(result, 120);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToChains_Succes()
        {
            result = LengthsConverter.ConvertMilesToChains(15);

            Assert.AreEqual(result, 1200);
        }
    }
}
