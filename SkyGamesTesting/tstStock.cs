using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sky_Games_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock aStock = new clsStock();
            Assert.IsNotNull(aStock);
        }
    }
}
