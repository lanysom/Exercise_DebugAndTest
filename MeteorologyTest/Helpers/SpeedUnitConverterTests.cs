using Microsoft.VisualStudio.TestTools.UnitTesting;
using Meteorology;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meteorology.Tests
{
    [TestClass()]
    public class SpeedUnitConverterTests
    {
        [TestMethod()]
        public void ConvertMilesPerHourToMeterPerSecondTest()
        {
            SpeedUnitConverter speedUnitConverter = new SpeedUnitConverter();

            double result = speedUnitConverter.ConvertMilesPerHourToMeterPerSecond(9);

            Assert.AreEqual(4.02336, result);
        }

        [TestMethod()]
        public void ConvertMeterPerSecondToMilesPerHourTest()
        {
            SpeedUnitConverter speedUnitConverter = new SpeedUnitConverter();

            double result = speedUnitConverter.ConvertMeterPerSecondToMilesPerHour(9);

            Assert.AreEqual(20.13246, result);
        }
    }
}