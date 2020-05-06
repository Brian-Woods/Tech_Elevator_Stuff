using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPU2 : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;

            weight = weight / 16;

            rate = weight * .050 * distance;
            
            return rate;
        }
        //If "2-Day Business" then rate = (weight * 0.050) * distance.
    }
}
