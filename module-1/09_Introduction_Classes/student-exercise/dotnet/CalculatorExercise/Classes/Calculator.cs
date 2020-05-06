using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
      
       

       
        public int Result { get; private set; }

        public int Add(int addend)
        {
            this.Result += addend;

            return this.Result;
        }

        public int Multiply(int multipier)
        {
            return this.Result *= multipier;
        }
        public int Power(int exponent)
        {
            var absolute = Math.Abs(exponent);

            this.Result =  Convert.ToInt32(Math.Pow(this.Result, absolute));
            return this.Result;
        }

        public int Subtract(int subtrahend)
        {
            this.Result -= subtrahend;

            return this.Result;
        }
        public void Reset()
        {
            this.Result = 0;
                }

    }


}


