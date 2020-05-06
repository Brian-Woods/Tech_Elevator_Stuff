using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        public WordCount wc;
        [TestInitialize]
        public void WordCount()
        {
            wc = new WordCount();
        }




        [TestMethod]
        public void WordCountABCTest()
        {
            string[] words = { "a", "b", "a" };

            Dictionary<string, int> result = wc.GetCount(words);

            Dictionary<string, int> expectedResult = new Dictionary<string, int> { { "a", 2 }, { "b", 1 } };

            CollectionAssert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void WordCountZeroLengthTest()
        {
            string[] words = { "", "", "" };

            Dictionary<string, int> result = wc.GetCount(words);

            Dictionary<string, int> expectedResult = new Dictionary<string, int> { { "", 3 } };

            CollectionAssert.AreEqual(expectedResult, result);

        }

    }
}


      



