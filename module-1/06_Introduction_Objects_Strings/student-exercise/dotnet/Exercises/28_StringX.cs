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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            if(str.Length < 3)
            {
                return str;
            }
            String returnString = str.Substring(0,1); // adds initial return string letter


            for(int i = 1;  i <str.Length - 1;  i++) // first and final letters accounted for
            {
                    if(str.Substring(i,1) != "x")
                            {
                                returnString +=  str.Substring(i, 1);
                             } // adds letters not x
            
            }

            returnString += str.Substring(str.Length-1, 1); // adds last return string letter

            return returnString;

           
        }
    }
}
