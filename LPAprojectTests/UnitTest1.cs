using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LPAprojectTests
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


