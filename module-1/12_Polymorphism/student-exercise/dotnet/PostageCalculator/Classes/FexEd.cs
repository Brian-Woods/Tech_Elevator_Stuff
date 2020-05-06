using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class FexEd : IDeliveryDriver
    {
        public double CalculateRate(int distance, double weight)
        {

            double rate = 20.00;

            if(distance > 500)
            { 
                rate = rate + 5.00;
            }
            if (weight > 3 * 16)
            {
                rate += 3.00;
            }
            return rate;
        }


    }
}
