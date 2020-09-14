using Microsoft.VisualStudio.TestTools.UnitTesting;
using Meteorology;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meteorology.Tests
{
    [TestClass()]
    public class TemperatureScaleConverterTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            TemperatureScaleConverter temperatureScaleConverter = new TemperatureScaleConverter();

            double result = temperatureScaleConverter.CelsiusToFahrenheit(5);

            Assert.AreEqual(41, result);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            TemperatureScaleConverter temperatureScaleConverter = new TemperatureScaleConverter();

            double result = temperatureScaleConverter.FahrenheitToCelsius(50);

            Assert.AreEqual(10, result);
        }
    }
}