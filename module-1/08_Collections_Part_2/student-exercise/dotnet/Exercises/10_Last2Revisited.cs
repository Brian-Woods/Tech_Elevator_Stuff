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
         * Just when you thought it was safe to get back in the water --- Last2Revisited!!!!
         *
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1.
         *
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.
         *
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *
         * Last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         *
         */

        //  , int Lastword
        public Dictionary<string, int> Last2Revisited(string[] words)
        {
            int Lastword = 0;
            // for every word in words, 
            // call last2 , pass in word as parameter, add word, result to the dictionary
           

            foreach(string word in words)

            {
                Last2(word);
                
                int count = Lastword;

                
            }

            int Last2(string str)
            {
                int count = -1;
                while (str.Length >= 2)
                {

                    string stringEnd = str.Substring(str.Length - 2, 2);
                    for (int i = 0; i < str.Length - 1; i++)
                    {
                        if (str.Substring(i, 2) == stringEnd)
                        {
                            count++;
                        }
                    }
                    if (count == -1)
                    {
                        return 0;
                    }
                    else
                    {
                        return count;
                    }

                }

                return 0;
            }

            return null;

        }

       
    }




}
