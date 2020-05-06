using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return true if the array contains no 1's and no 3's.
         Lucky13([0, 2, 4]) → true
         Lucky13([1, 2, 3]) → false
         Lucky13([1, 2, 4]) → false
         */
        public bool Lucky13(int[] nums)
        {
            bool no13 = true;
            for(int i =0; i<=nums.Length - 1; i++)
            {
                if((nums[i]) == 1)
                    {
                    no13 = false;
                    return no13;
                }
                if((nums[i]) == 3)
                    {
                    no13 = false;
                    return no13;
                }
            }

            return no13;
        }

    }
}
