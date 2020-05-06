using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {

        [TestMethod]

        public void FrontTimesabc()
        {
            FrontTimes frontString = new FrontTimes();
            string myString = frontString.GenerateString("abc", 3);
            Assert.AreEqual("abcabcabc", myString);

        }

        [TestMethod]

        public void FrontTimes5a()
        {
            FrontTimes frontString = new FrontTimes();
            string myString = frontString.GenerateString("a", 5);
            Assert.AreEqual("aaaaa", myString);

        }

        [TestMethod]

        public void FrontTimes210()
        {
            FrontTimes frontString = new FrontTimes();
            string myString = frontString.GenerateString("10", 2);
            Assert.AreEqual("1010", myString);

        }

    }
}
