using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sky_Games_Testing
{
    [TestClass]
    public class SupplierName
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsSupplier AnSupplierName = new clsSupplier();
            Assert.IsNotNull(AnSupplierName);
        }
    }
}
