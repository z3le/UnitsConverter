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
        public decimal result = 0;

        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToMeters_Succes()
        {
            result = LengthsConverter.ConvertCentimetersToMeters(20);

            Assert.AreEqual(result, 0.2M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToMillimeters_Succes()
        {
            result = LengthsConverter.ConvertCentimetersToMillimeters(20);

            Assert.AreEqual(result, 200);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToFeet_Succes()
        {
            result = LengthsConverter.ConvertCentimetersToFeet(20);

            Assert.AreEqual(result, 0.656168M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToInches_Succes()
        {
            result = LengthsConverter.ConvertCentimetersToInches(20);

            Assert.AreEqual(result, 7.87402M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToMicrometer_Succes()
        {
            result = LengthsConverter.ConvertCentimetersToMicrometers(20);

            Assert.AreEqual(result, 200000);
        }
    }
}
