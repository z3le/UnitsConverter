using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsFeetConverterTests
    {
        public decimal result = 0;

        [TestMethod]
        public void LenghtsConverter_ConvertFeetToMiles_Succes()
        {
            result = LengthsConverter.ConvertFeetToMiles(2000);

            Assert.AreEqual(result, 0.378788000M);
        }
    }
}
