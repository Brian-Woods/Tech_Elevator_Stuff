using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {

        [TestMethod]
        public void IsItTheSameTestNo()
        {

            SameFirstLast myArray = new SameFirstLast();
            int[] array = new int[] { 1, 2, 3 };
            bool myResult =myArray.IsItTheSame(array);
            Assert.AreEqual(false, myResult);
                    
        }
        [TestMethod]
        public void IsItTheSameTestYes()
        {

            SameFirstLast myArray = new SameFirstLast();
            int[] array = new int[] { 3, 2, 3 };
            bool myResult = myArray.IsItTheSame(array);
            Assert.AreEqual(true, myResult);

        }


    }
}
