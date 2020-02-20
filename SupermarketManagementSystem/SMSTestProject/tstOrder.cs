using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstOrder
    {
        // some good data to pass the method 
        Int32  Quantity = 1;
        double Price = 10.99;

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
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            Int32 Quantity = 0;
            
            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There shold be an error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMinBoundary()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            Int32 Quantity = 0;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            Int32 Quantity = 2;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be NO error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMaxBoundary()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            Int32 Quantity = 100;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be NO error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            Int32 Quantity = 101;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            Int32 Quantity = 50;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be no error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            Int32 Quantity = 10000;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreEqual(Error, "");

        }
        ///////////////////////////////////////////////////////////
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            double Price = 0;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There shold be an error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMinBoundary()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            double Price = 0.20;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            double Price = 1.20;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be NO error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMaxBoundary()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
           double Price = 10000;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be NO error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            double Price = 10001;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMid()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            double Price = 5000;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be no error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            double Price = 100000;

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreEqual(Error, "");

        }

    }
}
