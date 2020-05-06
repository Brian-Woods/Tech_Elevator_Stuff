using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPU : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {
            double rate = 0;
            weight = weight / 16;
            rate = weight * .075 * distance;
           
            //If "Next Day" then rate = (weight * 0.075) * distance.


            return rate;
        }

    }
}
