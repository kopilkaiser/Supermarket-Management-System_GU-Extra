using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstOrderline
    {
        
        // some good data to pass the method 
        int OrderlineId = 1;
        string Quantity = "2";
        string InventoryId = "1";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class Orderline
            clsOrderline AnOrderline = new clsOrderline();
            // test to see that it exist
            Assert.IsNotNull(AnOrderline);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of class Orderlineline
            clsOrderline AnOrderline = new clsOrderline();
            // create some test dat to assign the property
            Int32 Quantity = 1;
            // assign the data to the property
            AnOrderline.Quantity = Quantity;
            //test to see that it exist
            Assert.AreEqual(AnOrderline.Quantity, Quantity);

        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of class Orderlineline
           clsOrderline AnOrderline = new clsOrderline();
            // create an string variable to store the result of validation
            String Error = "";
            // create some test data to the test method
            string Quantity = "0";

            // invoke the method
            Error = AnOrderline.Valid(Quantity, InventoryId);
            // test to see that result is ok , e, g - There shold be an error message
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMinBoundary()
        {
            //create an instance of class Orderline
           clsOrderline AnOrderline = new clsOrderline();
            // create an string variable to store the result of validation
            String Error = "";
            // create some test data to the test method
            string Quantity = "0";

            // invoke the method
            Error = AnOrderline.Valid(Quantity, InventoryId);
            // test to see that result is ok , e, g - There should be an error message
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of class Orderline
           clsOrderline AnOrderline = new clsOrderline();
            // create an string variable to store the result of validation
            String Error = "";
            // create some test data to the test method
            string Quantity = "2";

            // invoke the method
            Error = AnOrderline.Valid(Quantity, InventoryId);
            // test to see that result is ok , e, g - There should be NO error message
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMaxBoundary()
        {
            //create an instance of class Orderline
           clsOrderline AnOrderline = new clsOrderline();
            // create an string variable to store the result of validation
            String Error = "";
            // create some test data to the test method
            string Quantity = 100.ToString();

            // invoke the method
            Error = AnOrderline.Valid(Quantity, InventoryId);
            // test to see that result is ok , e, g - There should be NO error message
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of class Orderline
           clsOrderline AnOrderline = new clsOrderline();
            // create an string variable to store the result of validation
            String Error = "";
            // create some test data to the test method
            string Quantity = "101";

            // invoke the method
            Error = AnOrderline.Valid(Quantity,  InventoryId);
            // test to see that result is ok , e, g - There should be an error message
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of class Orderline
           clsOrderline AnOrderline = new clsOrderline();
            // create an string variable to store the result of validation
            String Error = "";
            // create some test data to the test method
            string Quantity = "50";

            // invoke the method
            Error = AnOrderline.Valid(Quantity, InventoryId);
            // test to see that result is ok , e, g - There should be no error message
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create an instance of class Orderline
           clsOrderline AnOrderline = new clsOrderline();
            // create an string variable to store the result of validation
            String Error = "";
            // create some test data to the test method
            string Quantity = 10000.ToString();

            // invoke the method
            Error = AnOrderline.Valid(Quantity,  InventoryId);
            // test to see that result is ok , e, g - There should be an error message
            Assert.AreNotEqual(Error, "");

        }
        ////////////////////////////
        /// // testing for Inventory Id
        /// <summary>
        /// //////////////
        /// </summary>
        [TestMethod]
        public void InventoryIdExtremeMin()
        {
            clsOrderline AnOrderline = new clsOrderline();
            string Error = "";
            string InventoryId = "";
            Error = AnOrderline.Valid(Quantity,  InventoryId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InventoryIdMinMinusOne()
        {
            clsOrderline AnOrderline = new clsOrderline();
            string Error = "";
            string InventoryId = "";
            Error = AnOrderline.Valid(Quantity, InventoryId);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void InventoryIdMinBoundary()
        {
            clsOrderline AnOrderline = new clsOrderline();
            string Error = "";
            string InventoryId = "a";
            Error = AnOrderline.Valid(Quantity, InventoryId);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void InventoryIdMinPlusOne()
        {
            clsOrderline AnOrder = new clsOrderline();
            string Error = "";
            string InventoryId = "aa";
            Error = AnOrder.Valid(Quantity, InventoryId);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void InventoryIdMaxMinusOne()
        {
            clsOrderline AnOrder = new clsOrderline();
            string Error = "";
            string InventoryId = "";
            InventoryId = InventoryId.PadRight(9999, 'a');
            Error = AnOrder.Valid(Quantity, InventoryId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InventoryIdMaxBoundary()
        {
            clsOrderline AnOrderline = new clsOrderline();
            string Error = "";
            string InventoryId = "";
            InventoryId = InventoryId.PadRight(10000, 'a');
            Error = AnOrderline.Valid(Quantity, InventoryId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InventoryIdMaxPlusOne()
        {
            clsOrderline AnOrderline = new clsOrderline();
            string Error = "";
            string InventoryId = "";
            InventoryId = InventoryId.PadRight(10001, 'a');
            Error = AnOrderline.Valid(Quantity, InventoryId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void InventoryIdMid()
        {
            clsOrder AnOrderline = new clsOrder();
            string Error = "";
            string InventoryId = "";
            InventoryId = InventoryId.PadRight(5000, 'a');
            Error = AnOrderline.Valid(Quantity, InventoryId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdExtremeMax()
        {
            clsOrderline AnOrder = new clsOrderline();
            string Error = "";
            string InventoryId = "";
            InventoryId = InventoryId.PadRight(50000, 'a');
            Error = AnOrder.Valid(Quantity, InventoryId);
            Assert.AreNotEqual(Error, "");
        }
    }

}  



    

