using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]
        public void MaxEnd3GoodTest()
        {
            MaxEnd3 myArray = new MaxEnd3();
            int[] expectedResult = new int[] { 3,3, 3 };
            int[] array = new int[] { 1, 2, 3 };
            int[] match = myArray.MakeArray(array);
            CollectionAssert.AreEquivalent(expectedResult, match);
        }
    }
}
