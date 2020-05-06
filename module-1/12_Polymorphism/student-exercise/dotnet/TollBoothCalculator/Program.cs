using System;
using System.Text;
using System.Collections.Generic;
using TollBoothCalculator.Classes;



namespace TollBoothCalculator
{
    public class Program
    {

        static void Main(string[] args)
        {
          
            //Make list of vehicles
            
            var vehicleList = new List<IVehicle>();
            vehicleList.Add(new Car(false));
            vehicleList.Add(new Car(true));
            vehicleList.Add(new Truck(4));
            vehicleList.Add(new Truck(6)); 
            vehicleList.Add(new Truck(8));
            vehicleList.Add(new Tank());

            
            double totalRevenue = 0.0;
            int totalMiles = 0;

            // foreach loop, inside the loop, generate a random number, call calculate tool 
            // for each

            foreach (IVehicle vehicle in vehicleList)
            {
                Random random = new Random();

                int randomNumber = random.Next(10, 240);

                double toll = vehicle.CalculateToll(randomNumber);

                
                string.Format("{0,-25}", "{1,20}", "{2,40}", vehicleList, totalMiles, toll);

                Console.WriteLine("vehicle = " + vehicle.ToString().Substring(vehicle.ToString().LastIndexOf('.')+1) + " Miles = " + randomNumber + "  Cost = " + toll);

                totalRevenue += toll;
                totalMiles += randomNumber;

                

            }
            Console.WriteLine();
            Console.WriteLine("Total Miles Traveled :" + totalMiles);
            Console.WriteLine("Total Revenue $" + totalRevenue);

        }
    }
}
