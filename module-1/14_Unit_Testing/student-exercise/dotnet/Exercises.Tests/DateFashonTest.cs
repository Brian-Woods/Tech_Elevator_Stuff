using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashonTest
    {
        [TestMethod]

        public void GetATable10s()
        {
            DateFashion table = new DateFashion();
            int haveTable = table.GetATable(10,10);
            Assert.AreEqual(2,haveTable);
        }

        [TestMethod]

        public void GetATable1s()
        {
            DateFashion table = new DateFashion();
            int haveTable = table.GetATable(1, 1);
            Assert.AreEqual(0, haveTable);
        }

        [TestMethod]

        public void GetATable5s()
        {
            DateFashion table = new DateFashion();
            int haveTable = table.GetATable(5, 5);
            Assert.AreEqual(1, haveTable);
        }
        [TestMethod]

        public void GetATable1and10()
        {
            DateFashion table = new DateFashion();
            int haveTable = table.GetATable(1, 10);
            Assert.AreEqual(0, haveTable);
        }
        [TestMethod]

        public void GetATable3and10()
        {
            DateFashion table = new DateFashion();
            int haveTable = table.GetATable(3, 10);
            Assert.AreEqual(2, haveTable);
        }
    }
}
