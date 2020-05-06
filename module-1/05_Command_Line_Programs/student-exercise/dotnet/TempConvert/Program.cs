using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temp?");

            var ourTemp = Console.ReadLine();

            Console.WriteLine("C or F?");

            var degreesCorF = Console.ReadLine();

            double temp = double.Parse(ourTemp);

            if (degreesCorF == "C" || degreesCorF == "c")
            {
                var farenheight = (temp - 32) / 1.8;

                Console.WriteLine("The temp converted to Farenheight is " + farenheight);
            }

            else if (degreesCorF == "F" || degreesCorF == "f")
            {
                var celcius = (temp * 1.8) + 32;

                Console.WriteLine("The temp converted to Celcius is " + celcius);
            }

            else
            {
                Console.WriteLine("Bad Input");
            }


        
    }
    }
}
