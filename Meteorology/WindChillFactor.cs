using System;

namespace Meteorology
{
    public class WindChillFactor
    {
        public SpeedUnit SpeedUnit { get; }
        public TemperatureScale TemperatureScale { get; }

        /// <summary>
        /// Creates an instance of the WindChillFactor class.
        /// </summary>
        /// <param name="speedUnit">The unit in which wind speed is indicated</param>
        /// <param name="temperatureScale">The unit in which temperature is indicated</param>
        public WindChillFactor(SpeedUnit speedUnit, TemperatureScale temperatureScale)
        {
            SpeedUnit = speedUnit;
            TemperatureScale = temperatureScale;
        }

        /// <summary>
        /// Uses formula from https://www.weather.gov/media/epz/wxcalc/windChill.pdf 
        /// </summary>
        public double CalulateChillFactorTemperature(double windSpeed, double temperature)
        {
            throw new NotImplementedException();
        }
    }
}
