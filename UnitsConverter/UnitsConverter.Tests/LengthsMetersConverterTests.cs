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
        public decimal result = 0;

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToKilometers_Succes()
        {
            result = LengthsConverter.ConvertMetersToKilometers(20);

            Assert.AreEqual(result, 0.02M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToMiles_Succes()
        {
            result = LengthsConverter.ConvertMetersToMiles(20);

            Assert.AreEqual(result, 0.012427420M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToCentimeters_Succes()
        {
            result = LengthsConverter.ConvertMetersToCentimeters(20);

            Assert.AreEqual(result, 2000);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToMillimeters_Succes()
        {
            result = LengthsConverter.ConvertMetersToMillimeters(20);

            Assert.AreEqual(result, 20000);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToFeet_Succes()
        {
            result = LengthsConverter.ConvertMetersToFeet(20);

            Assert.AreEqual(result, 65.6168M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToInches_Succes()
        {
            result = LengthsConverter.ConvertMetersToInches(20);

            Assert.AreEqual(result, 787.402M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToYards_Succes()
        {
            result = LengthsConverter.ConvertMetersToYards(20);

            Assert.AreEqual(result, 21.87220M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMetersToDecimeters_Succes()
        {
            result = LengthsConverter.ConvertMetersToDecimeters(20);

            Assert.AreEqual(result, 200);
        }
    }
}
