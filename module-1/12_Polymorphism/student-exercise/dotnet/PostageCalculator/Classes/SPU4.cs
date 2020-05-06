using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPU4 : IDeliveryDriver
    {
        //If "4-Day Ground" then rate = (weight * 0.0050) * distance.
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;

            weight = weight / 16;

            rate = weight * .0050 * distance;

            return rate;
        }
    }
}
