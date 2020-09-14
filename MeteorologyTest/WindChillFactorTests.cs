using Meteorology;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MeteorologyTest
{
    [TestClass]
    public class WindChillFactorTests
    {
        [TestMethod]
        public void CalculateTest()
        {
            TemperatureScale temperatureScale = TemperatureScale.Celsius;
            SpeedUnit speedUnit = SpeedUnit.MeterPerSecond;
            double temperature = 5.0;
            double windSpeed = 9.0;

            WindChillFactor windChillFactor = new WindChillFactor(speedUnit, temperatureScale);

            double result = windChillFactor.Calulate(windSpeed, temperature);

            Assert.AreEqual(-0.1, result);
        }

        [TestMethod]
        public void CalculateTestWithTooHighTemperature()
        {
            TemperatureScale temperatureScale = TemperatureScale.Fahrenheit;
            SpeedUnit speedUnit = SpeedUnit.MeterPerSecond;
            double temperature = 50.0;
            double windSpeed = 9.0;

            WindChillFactor windChillFactor = new WindChillFactor(speedUnit, temperatureScale);

            Assert.ThrowsException<Exception>(() =>
            {
                double result = windChillFactor.Calulate(windSpeed, temperature);
            });
        }
    }
}
