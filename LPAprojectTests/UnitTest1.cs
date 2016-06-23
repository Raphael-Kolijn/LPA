using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LPAprojectTests // Geen tijd en aandacht besteed aan unit tests. Deze werkende test bj wijze van demonstratie
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testOpenDBConnection()
        {
            bool returnValue;
            returnValue = LPAproject.database.OpenConnection();
            Assert.AreEqual(true, returnValue);
        }
    }
}


