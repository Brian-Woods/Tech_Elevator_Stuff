using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void Lucky13Test024()
        {
            Lucky13 myArray = new Lucky13();
            int[] array = new int[] { 0, 2, 4 };
            bool match = myArray.GetLucky(array);
            Assert.AreEqual(true, match);
        }

        [TestMethod]
        public void Lucky13Test014()
        {
            Lucky13 myArray = new Lucky13();
            int[] array = new int[] { 0, 1, 4 };
            bool match = myArray.GetLucky(array);
            Assert.AreEqual(false, match);
        }

    }
}
