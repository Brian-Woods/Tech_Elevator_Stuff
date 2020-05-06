using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;



namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNamesTest
    {
        [TestMethod]
        public void GetHerdTest()
        {
            AnimalGroupName name = new AnimalGroupName();
            string herd = name.GetHerd("rhino");
            Assert.AreEqual("Crash", herd);
            
        }
        [TestMethod]
        public void GetHerdTestCAPS()
        {
            AnimalGroupName name = new AnimalGroupName();
            string herd = name.GetHerd("RHINO");
            Assert.AreEqual("Crash", herd);

        }

        [TestMethod]
        public void GetHerdTestDonkey()
        {
            AnimalGroupName name = new AnimalGroupName();
            string herd = name.GetHerd("donkey");
            Assert.AreEqual("unknown", herd);

        }

        [TestMethod]
        public void GetHerdTestNull()
        {
            AnimalGroupName name = new AnimalGroupName();
            string herd = name.GetHerd(null);
            Assert.AreEqual("unknown", herd);

        }




    }
}
