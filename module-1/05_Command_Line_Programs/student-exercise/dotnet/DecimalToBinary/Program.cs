using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
           
          Console.WriteLine("Enter a base 10 number:");
            
         var  strbase10 = Console.ReadLine();
           
          var  base10 = int.Parse(strbase10);
           
          Console.WriteLine("The binary equivalant is: " + ConvertNumberToBinary(base10));
        }
        private static string ConvertNumberToBinary(int base10)
        {
            string binary = "";
          
            while (base10 > 0)
            {
                binary = (base10 % 2) + binary;
                base10 = base10 / 2;
            }

            return binary;
        }
    }


   
}

