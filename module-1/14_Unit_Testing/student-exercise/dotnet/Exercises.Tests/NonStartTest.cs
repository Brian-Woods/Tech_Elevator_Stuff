using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {

        [TestMethod]

        public void NonStartEllohere()
        {
            NonStart frontString = new NonStart();
            string myString = frontString.GetPartialString("hello", "there");
            Assert.AreEqual("ellohere", myString);

        }

        [TestMethod]

        public void NonStartHellohere()
        {
            NonStart frontString = new NonStart();
            string myString = frontString.GetPartialString("hello", "there");
            Assert.AreNotEqual("hellohere", myString);

        }

    }

}