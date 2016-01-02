using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsMetersConverterTests
    {
        [TestMethod]
        public void LenghtsConverter_ConvertMetersToKilometers_Succes()
        {
            decimal kilometers = LengthsConverter.ConvertMetersToKilometers(20);

            Assert.AreEqual(kilometers, 0.02M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToMiles_Succes()
        {
            decimal kilometers = LengthsConverter.ConvertMetersToMiles(20);

            Assert.AreEqual(kilometers, 0.012427420M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToCentimeters_Succes()
        {
            decimal kilometers = LengthsConverter.ConvertMetersToCentimeters(20);

            Assert.AreEqual(kilometers, 2000);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToMillimeters_Succes()
        {
            decimal kilometers = LengthsConverter.ConvertMetersToMillimeters(20);

            Assert.AreEqual(kilometers, 20000);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToFeet_Succes()
        {
            decimal kilometers = LengthsConverter.ConvertMetersToFeet(20);

            Assert.AreEqual(kilometers, 65.6168M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToInches_Succes()
        {
            decimal kilometers = LengthsConverter.ConvertMetersToInches(20);

            Assert.AreEqual(kilometers, 787.402M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToYards_Succes()
        {
            decimal kilometers = LengthsConverter.ConvertMetersToYards(20);

            Assert.AreEqual(kilometers, 21.87220M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToDecimeters_Succes()
        {
            decimal kilometers = LengthsConverter.ConvertMetersToDecimeters(20);

            Assert.AreEqual(kilometers, 200);
        }
    }
}
