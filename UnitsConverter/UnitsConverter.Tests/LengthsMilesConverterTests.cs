using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsMilesConverterTests
    {
        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToMeters_Succes()
        {
            decimal meters = LengthsConverter.ConvertCentimetersToMeters(20);

            Assert.AreEqual(meters, 0.2M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToMeters_Succes()
        {
            decimal meters = LengthsConverter.ConvertMilesToMeters(20);

            Assert.AreEqual(meters, 32186.941757728889389574649565M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToKilometers_Succes()
        {
            decimal kilometers = LengthsConverter.ConvertMilesToKilometers(20);

            Assert.AreEqual(kilometers, 32.186941757728889389574649565M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToFeet_Succes()
        {
            decimal feet = LengthsConverter.ConvertMilesToFeet(20);

            Assert.AreEqual(feet, 105600M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToInches_Succes()
        {
            decimal inches = LengthsConverter.ConvertMilesToInches(5);

            Assert.AreEqual(inches, 316800);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToYards_Succes()
        {
            decimal yards = LengthsConverter.ConvertMilesToYards(5);

            Assert.AreEqual(yards, 8800);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToNauticalMiles_Succes()
        {
            decimal nauticalMiles = LengthsConverter.ConvertMilesToNauticalMiles(20);

            Assert.AreEqual(nauticalMiles, 17.37960M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToFurlongs_Succes()
        {
            decimal furlongs = LengthsConverter.ConvertMilesToFurlongs(15);

            Assert.AreEqual(furlongs, 120);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToChains_Succes()
        {
            decimal chains = LengthsConverter.ConvertMilesToChains(15);

            Assert.AreEqual(chains, 1200);
        }
    }
}
