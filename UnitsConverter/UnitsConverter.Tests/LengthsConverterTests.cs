﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitsConverter.Tests
{
    [TestClass]
    public class LengthsConverterTests
    {
        [TestMethod]
        public void LenghtsConverter_ConvertCentimetersToMeters_Succes()
        {
            decimal meters = LengthsConverter.ConvertCentimetersToMeters(20);

            Assert.AreEqual(meters, 0.2M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertKilometersToMiles_Succes()
        {
            decimal meters = LengthsConverter.ConvertKilometersToMiles(15);

            Assert.AreEqual(meters, 9.320565M);
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
            decimal meters = LengthsConverter.ConvertMilesToKilometers(20);

            Assert.AreEqual(meters, 32.186941757728889389574649565M);
        }

        [TestMethod]
        public void LenghtsConverter_ConvertMilesToFeet_Succes()
        {
            decimal meters = LengthsConverter.ConvertMilesToFeet(20);

            Assert.AreEqual(meters, 105600M);
        } 
    }
}