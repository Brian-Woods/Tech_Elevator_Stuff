using System;
using System.Collections.Generic;
using System.Text;
using TollBoothCalculator.Classes;


namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {
             public bool HasTrailer { get; }


        public Car(bool hasTrailer)
        {
              HasTrailer = hasTrailer;
        }



        public double CalculateToll(int distance)
        {
            double tollAmount;

            tollAmount = distance * 0.020;

                if(HasTrailer == true)
                {
                    tollAmount += 1.00;
                }
            
                return tollAmount;
        }



    }
}
