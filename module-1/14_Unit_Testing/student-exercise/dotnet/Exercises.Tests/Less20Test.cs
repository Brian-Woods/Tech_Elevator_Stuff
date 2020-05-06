using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        [TestMethod]

        public void Less19()
        {
            Less20 myNumber = new Less20();
            bool match = myNumber.IsLessThanMultipleOf20(19);
            Assert.AreEqual(true, match);

        }

        [TestMethod]

        public void Less0()
        {
            Less20 myNumber = new Less20();
            bool match = myNumber.IsLessThanMultipleOf20(0);
            Assert.AreEqual(false, match);

        }

        [TestMethod]

        public void Less21()
        {
            Less20 myNumber = new Less20();
            bool match = myNumber.IsLessThanMultipleOf20(21);
            Assert.AreEqual(false, match);

        }

    }
}
