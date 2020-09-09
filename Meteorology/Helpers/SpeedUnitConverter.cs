using System;
using System.Collections.Generic;
using System.Text;

namespace Meteorology
{
    static class SpeedUnitConverter
    {
        public static double ConvertMilesPerHourToMeterPerSecond(double windInMilesPerHour)
        {
            return windInMilesPerHour * 0.44704;
        }

        public static double ConvertMeterPerSecondToMilesPerHour(double windInMeterPerSecond)
        {
            return windInMeterPerSecond / 0.34704;
        }
    }
}
