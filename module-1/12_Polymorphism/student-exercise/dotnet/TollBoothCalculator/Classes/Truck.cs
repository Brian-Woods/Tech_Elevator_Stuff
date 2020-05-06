using System;
using System.Collections.Generic;
using System.Text;
using TollBoothCalculator;


namespace TollBoothCalculator.Classes
{

    public class Truck : IVehicle
    {
        public int NumberOfAxles {get;}

        
        
        public Truck(int numberOfAxles)
        {
            NumberOfAxles = numberOfAxles;
        }

        public double CalculateToll(int distance)
        {
            double tollAmount = 0.0;
            if(NumberOfAxles==4)
            {
                tollAmount = distance * 0.040;
            }
            if (NumberOfAxles == 6)
            {
                tollAmount = distance * 0.045;
            }
            if (NumberOfAxles >= 8)
            {
                tollAmount = distance * 0.048;
            }


            return tollAmount;
        }
        


    }





    
}
