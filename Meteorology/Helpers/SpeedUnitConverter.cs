using System;
using System.Collections.Generic;
using System.Text;

namespace Meteorology
{
    class SpeedUnitConverter
    {
        public double ConverMilesPerHourToMeterPerSecond(int windInMilesPerHour)
        {
            return windInMilesPerHour * 0.44704;
        }

        public double ConverMeterPerSecondToMilesPerHour(int windInMeterPerSecond)
        {
            // 0.34704 must be 0.44704
            return windInMeterPerSecond / 0.44704;
        }
    }
}
