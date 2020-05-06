using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void StringBitsHello()
        {
            StringBits bitString = new StringBits();
            string myString = bitString.GetBits("Hello");
            Assert.AreEqual("Hlo", myString);

        }
    }
}
