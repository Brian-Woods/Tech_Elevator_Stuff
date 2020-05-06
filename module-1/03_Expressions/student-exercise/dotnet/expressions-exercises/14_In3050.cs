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
         Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both
         in the range 40..50 inclusive.
         In3050(30, 31) → true
         In3050(30, 41) → false
         In3050(40, 50) → true
         */
        public bool In3050(int a, int b)
        {
            if(a>29 && a<41)
            {
                if (b > 29 && b < 41)
                {
                    return true;
                }
            }

            if (a > 39 && a < 51)
            {
                if (b > 39 && b < 51)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
