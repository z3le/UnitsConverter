using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsInchesConverterTests
    {
        public decimal result = 0;

        [TestMethod]
        public void LenghtsConverter_ConvertInchesToMeters_Succes()
        {
            result = LengthsConverter.ConvertInchesToMeters(200);

            Assert.AreEqual(result, 5.08M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertInchesToFeet_Succes()
        {
            result = LengthsConverter.ConvertInchesToFeet(200);

            Assert.AreEqual(result, 16.6666600M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertInchesToCentimeters_Succes()
        {
            result = LengthsConverter.ConvertInchesToCentimeters(20);

            Assert.AreEqual(result, 50.8M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertInchesToMilimeters_Succes()
        {
            result = LengthsConverter.ConvertInchesToMilimeters(20);

            Assert.AreEqual(result, 508M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertInchesToYards_Succes()
        {
            result = LengthsConverter.ConvertInchesToYards(20);

            Assert.AreEqual(result, 0.5555560M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertInchesToDecimeters_Succes()
        {
            result = LengthsConverter.ConvertInchesToDecimeters(20);

            Assert.AreEqual(result, 5.08M);
        }
    }
}
