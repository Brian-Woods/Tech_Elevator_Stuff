using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the distance to convert?");

            var ourDistance = Console.ReadLine();

            Console.WriteLine("M(eters) or F(eet)?");

            var distanceForM = Console.ReadLine();

            double distance = double.Parse(ourDistance);

            if (distanceForM == "M" || distanceForM == "m")
            {
                var feet = distance * 0.3048;

                Console.WriteLine("The distance converted to Feet is " + feet);
            }

            else if (distanceForM == "F" || distanceForM == "f")
            {
                var meters = distance * 3.2808399;

                Console.WriteLine("The temp converted to Celcius is " + meters);
            }

            else
            {
                Console.WriteLine("Bad Input");
            }


        
    }  
    }
}
