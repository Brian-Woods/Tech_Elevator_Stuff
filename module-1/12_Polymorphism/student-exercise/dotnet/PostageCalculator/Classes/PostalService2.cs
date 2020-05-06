using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class PostalService2 : IDeliveryDriver
    {

        public double CalculateRate(int distance, double weight)
        {

            double rate;

            if (weight < (2 ))
            {
            
                rate = 0.0035 * distance;

                return rate;
            }
            if (weight < (8))
            {
        
                rate = 0.004 * distance;

                return rate;
            }
            if (weight < (15 ))
            {
                rate = 0.0047 * distance;

                return rate;
            }
            if (weight < 48)
            {
                rate = 0.0195 * distance;

                return rate;
            }
            if (weight < 128)
            {
                rate = 0.045 * distance;

                return rate;
            }
            if (weight > 128)
            {
                rate = 0.05 * distance;

                return rate;
            }
            return 0;
            //| Weight |           |           |           |
            //| Not | 1st Class | 2nd Class | 3rd Class |
            //| Over | Per Mile | Per Mile | Per Mile |
            //| --------| -----------| -----------| -----------|
            //| 2 oz. | 0.035 | 0.0035 | 0.0020 |
            //| 8 oz. | 0.040 | 0.0040 | 0.0022 |
            //| 15 oz. | 0.047 | 0.0047 | 0.0024 |
            //| 3 lbs.| 0.195 | 0.0195 | 0.0150 |
            //| 8 lbs.| 0.450 | 0.0450 | 0.0160 |
            //| --------| -----------| -----------| -----------|
            //| Over |           |           |           |
            //| 8 lbs. | 0.500 | 0.0500 | 0.0170 |









        }
    }
}
