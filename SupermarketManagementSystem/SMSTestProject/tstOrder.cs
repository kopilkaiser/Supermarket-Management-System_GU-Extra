using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            // instance of class Order
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
    }
}
