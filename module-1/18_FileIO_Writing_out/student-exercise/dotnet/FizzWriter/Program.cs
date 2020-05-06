using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace FizzWriter
{
    class Program
    {
        static void Main()
        {
            List<string> intStrings = new List<string>();
           
            int[] integerArray = new int[301]; 

            for(int i =1; i < 301; i++)
            {
                integerArray[i] = i;
            }

            for (int i = 0; i < integerArray.Length; i++)
            {
                
                if (integerArray[i] % 15 == 0)
                {
                    intStrings.Add(i + "FizzBuzz");
                }

                else if (integerArray[i] % 5 == 0 || integerArray[i].ToString().Contains("5"))
                {
                    intStrings.Add(i + "Buzz");
                }

                else if (integerArray[i] % 3 == 0 || integerArray[i].ToString().Contains("3"))
                {
                    intStrings.Add(i + "Fizz");
                }
                else
                {
                    intStrings.Add(i + " ");;
                }

            }
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Student\workspace\bwoods-c\module-1\18_FileIO_Writing_out\student-exercise\dotnet\FizzBuzz.txt", true))
                    foreach (String s in intStrings)
                    {
                    file.WriteLine(s);
                    }
                
        }
                   
   

    }

}





