using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            if(str.Length == 0 || str.Length == 1)
            {
                return false;
            }
            if (str.Length == 2)
            {
                if (str == "xx")
                { 
     
                    return true;
                }
                return false;
            }

            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 1) == "x")
                {
                    if (str.Substring(i, 2) == "xx")
                    {
                        return true;
                    }
                    return false;
                }

            }

            return false;
        }
    }
}
