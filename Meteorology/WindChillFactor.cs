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
            // The input to the formula must be in fahrenheit, so if the parameter value is in celsius it needs to be converted
            if (TemperatureScale == TemperatureScale.Celsius)
            {
                temperature = TemperatureScaleConverter.CelsiusToFahrenheit(temperature);
            }

            // The input to the formula must be in miles per hour, so if the parameter value is in meters it needs to be converted
            if (SpeedUnit == SpeedUnit.MeterPerSecond)
            {
                windSpeed = SpeedUnitConverter.ConverMeterPerSecondToMilesPerHour(windSpeed);
            }

            // Calculate the formula part and finally combine them
            double powerConstant = 0.16;
            double part1 = 35.74;
            double part2 = 0.6215 * temperature;
            double part3 = Math.Pow(windSpeed, powerConstant) * 35.75;
            double part4 = Math.Pow(windSpeed, powerConstant) * temperature * 0.4275;
            double chillDegreeResult = part1 + part2 + part4 - part3;

            // If input was in Celsius, the output should be as well
            if (TemperatureScale == TemperatureScale.Celsius)
            {
                chillDegreeResult = TemperatureScaleConverter.FahrenheitToCelsius(chillDegreeResult);
            }

            return Math.Round(chillDegreeResult, 1);
        }
    }
}
