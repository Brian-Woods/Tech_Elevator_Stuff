using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    
    [TestClass]
       
    public class CigarPartyTests
    {
                [TestMethod]

                public void CigarParty30F()
                {
                    CigarParty party = new CigarParty();
                    bool success = party.HaveParty(30, false);
                    Assert.IsFalse(success);
                }
                [TestMethod]
        public void CigarParty80T()
                {
                    CigarParty party = new CigarParty();
            bool success = party.HaveParty(80, true);
                            Assert.IsTrue(success);
                }

        [TestMethod]
        public void CigarPartyNeg1F()
        {
            CigarParty party = new CigarParty();
            bool success = party.HaveParty(-1, false);
            Assert.IsFalse(success);
        }

        [TestMethod]
        public void CigarParty60T()
        {
            CigarParty party = new CigarParty();
            bool success = party.HaveParty(60,false);
            Assert.IsTrue(success);
        }
        [TestMethod]
        public void CigarParty61F()
        {
            CigarParty party = new CigarParty();
            bool success = party.HaveParty(61, false);
            Assert.IsFalse(success);
        }

        [TestMethod]
        public void CigarParty61T()
        {
            CigarParty party = new CigarParty();
            bool success = party.HaveParty(61, true);
            Assert.IsTrue(success);
        }

    }
}
