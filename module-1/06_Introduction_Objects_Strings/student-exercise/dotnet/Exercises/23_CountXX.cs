﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx".
         CountXX("abcxx") → 1
         CountXX("xxx") → 2
         CountXX("xxxx") →
         */
        public int CountXX(string str)
        {
            int count = 0;
            for(int i = 1; i < str.Length; i++)
            {
                if(str.Substring(i-1, 2) == "xx")
                {
                    count++;
                }
            }
            return count;
        }
    }
}
