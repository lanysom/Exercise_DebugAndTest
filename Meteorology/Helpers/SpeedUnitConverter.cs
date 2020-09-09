using System;
using System.Collections.Generic;
using System.Text;

namespace Meteorology
{
    static class SpeedUnitConverter
    {
        public static double ConverMilesPerHourToMeterPerSecond(double windInMilesPerHour)
        {
            return windInMilesPerHour * 0.44704;
        }

        public static double ConverMeterPerSecondToMilesPerHour(double windInMeterPerSecond)
        {
            // 0.34704 must be 0.44704
            return windInMeterPerSecond * 2.23694;
        }
    }
}
