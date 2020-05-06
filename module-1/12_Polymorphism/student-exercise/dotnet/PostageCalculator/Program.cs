using System;
using System.Collections.Generic;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("What is the distance the package is travelling");

            var strDistance = Console.ReadLine();

            Console.WriteLine("What is the weight of the package");

            var strWeight = Console.ReadLine();

            double rate = 0.0;

            int distance = int.Parse(strDistance);
                      
            var weight = int.Parse(strWeight);

            Console.WriteLine("(P)ounds or (O)unces");

            var strPorO = Console.ReadLine();

            if (strPorO == "P" || strPorO == "p")// if in ounces, convert to pounds
            {
                weight *= 16;
            }

            var PackageList = new List<IDeliveryDriver>();
            PackageList.Add(new PostalService());
            PackageList.Add(new PostalService2());
            PackageList.Add(new PostalService3());
            PackageList.Add(new FexEd());
            PackageList.Add(new SPU());
            PackageList.Add(new SPU2());
            PackageList.Add(new SPU4());

            foreach (IDeliveryDriver package in PackageList)
            {
                rate = package.CalculateRate(distance, weight);

                Console.WriteLine("Shipping Method: " + package.ToString().Substring(package.ToString().LastIndexOf('.') + 1)+"   Cost $" + rate);
            }
        }
    }
}
