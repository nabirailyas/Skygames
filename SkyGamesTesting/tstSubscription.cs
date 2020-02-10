using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sky_Games_Testing
{
    [TestClass]
    public class tstSubscription
    {
        [TestMethod]
        private void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSubscription AnSubscription = new clsSubsciption();

            //test to see that it exists 
            Assert.IsNotNull(AnSubscription);


        }
    }
}
