using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstOrder
    {
        // some good data to pass the method 
        Int32 OrderQuantity = 1;
        double OrderPrice = 10.99;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // test to see that it exist 
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create some test dat to assign the property
            Int32 Quantity = 1;
            // assign the data to the property
            AnOrder.Quantity = Quantity;
            //test to see that it exist
            Assert.AreEqual(AnOrder.Quantity, Quantity);
            
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create some test dat to assign the property
            double Price = 10.99;
            // assign the data to the property
            AnOrder.Price = Price;
            //test to see that it exist
            Assert.AreEqual(AnOrder.Price, Price);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            Int32 Quantity = 1;
            // create some test data to asign the property
            double Price = 10.99;
            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There are no error message 
            Assert.AreEqual(Error, "");

        }

    }
}
