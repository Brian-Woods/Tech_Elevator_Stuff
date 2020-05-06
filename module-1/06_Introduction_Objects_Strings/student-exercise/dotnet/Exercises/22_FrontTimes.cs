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
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or
         whatever is there if the string is less than length 3. Return n copies of the front;
         FrontTimes("Chocolate", 2) → "ChoCho"
         FrontTimes("Chocolate", 3) → "ChoChoCho"
         FrontTimes("Abc", 3) → "AbcAbcAbc"
         */
        public string FrontTimes(string str, int n)
        {
            string tempString = "";
            if(str == "")
            {
                return tempString;
            }



            if(str.Length == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    tempString += str.Substring(0, 1);
                }
                return tempString;
            }


            if (str.Length == 2)
            {
                for (int i = 0; i < n; i++)
                {
                    tempString += str.Substring(0, 2);
                }
                return tempString;
            }


            if (str.Length >= 3)
            {
                
                for (int i = 0; i < n; i++)
                {
                    tempString += str.Substring(0, 3);
                }
            }
            return tempString;
        }
   
    }
}
