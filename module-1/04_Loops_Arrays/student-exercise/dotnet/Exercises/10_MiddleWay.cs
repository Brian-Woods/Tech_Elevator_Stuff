﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle
         elements.
         MiddleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
         MiddleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
         MiddleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
         */
        public int[] MiddleWay(int[] a, int[] b)
        {
            int[] middleArray = new int[2];
            middleArray[0] = a[1];
            middleArray[1] = b[1];



            return middleArray;
        }

    }
}
