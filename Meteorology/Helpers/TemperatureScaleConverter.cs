using System;
using System.Collections.Generic;
using System.Text;

namespace Meteorology
{
    static class TemperatureScaleConverter
    {
        /// <summary>
        /// Converts a temperature from celsius to fahrenheit 
        /// </summary>
        /// <param name="degreesInC">The temperature in celsius</param>
        /// <returns>A value representing the temperature in fahrenheit</returns>
        public static double CelsiusToFahrenheit(double degreesInC)
        {
            // changed - to +
            return degreesInC * 1.8 + 32;
        }

        /// <summary>
        /// Converts a temperature from fahrenheit to celsius
        /// </summary>
        /// <param name="degreesInF">The temperature in fahrenheit</param>
        /// <returns>A value representing the vlue in celsius</returns>
        public static double FahrenheitToCelsius(double degreesInF)
        {
            // changed + to -
            return (degreesInF - 32) / 1.8;
        }
    }
}
