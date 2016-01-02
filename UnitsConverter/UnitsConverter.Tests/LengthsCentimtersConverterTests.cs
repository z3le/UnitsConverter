using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsCentimtersConverterTests
    {
        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToMeters_Succes()
        {
            decimal meters = LengthsConverter.ConvertCentimetersToMeters(20);

            Assert.AreEqual(meters, 0.2M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToMillimeters_Succes()
        {
            decimal millimeters = LengthsConverter.ConvertCentimetersToMillimeters(20);

            Assert.AreEqual(millimeters, 200);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToFeet_Succes()
        {
            decimal millimeters = LengthsConverter.ConvertCentimetersToFeet(20);

            Assert.AreEqual(millimeters, 0.656168M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToInches_Succes()
        {
            decimal millimeters = LengthsConverter.ConvertCentimetersToInches(20);

            Assert.AreEqual(millimeters, 7.87402M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToMicrometer_Succes()
        {
            decimal millimeters = LengthsConverter.ConvertCentimetersToMicrometers(20);

            Assert.AreEqual(millimeters, 200000);
        }
    }
}
