using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstOrder
    {
        // some good data to pass the method 
        int OrderId = 1;

        string InventoryId = 2.ToString();
        string Quantity = "22";
        string Price = "20.20";              ////10.99m.ToString();
        string PurchasedDate = DateTime.Now.Date.ToString();


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
            decimal Price = 10.99m;
            // assign the data to the property
            AnOrder.Price = Price;
            //test to see that it exist
            Assert.AreEqual(AnOrder.Price, Price);

        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class 
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            string Quantity = 1.ToString();
            // create some test data to asign the property
            string Price = 10.99m.ToString();
            string PurchasedDate = DateTime.Now.Date.ToString();
            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            // test to see that result is ok , e, g - There are no error message 
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PurchasedDatePropertyOK()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            DateTime PurchasedDate = DateTime.Now.Date;
            AnOrder.PurchasedDate = PurchasedDate;
            Assert.AreEqual(PurchasedDate, AnOrder.PurchasedDate);
        }
        

        public void PurchasedDateExtremeMin()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(-100);
            string PurchasedDate = TestDate.ToString();
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PurchasedDateMinMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddDays(-1);
            string PurchasedDate = TestDate.ToString();
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PurchasedDateMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string PurchasedDate = DateTime.Now.Date.ToString();
            string Error = "";
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PurchasedDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(100);
            string PurchasedDate = TestDate.ToString();
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PurchasedDateInvalidDataType()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PurchasedDate = "a";
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            string Quantity = "0";

            // invoke the method 
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            // test to see that result is ok , e, g - There shold be an error message 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMinBoundary()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            string Quantity = "0";

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            string Quantity = "2";

            // invoke the method 
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
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
            string Quantity = 100.ToString();

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
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
            string Quantity = "101";

            // invoke the method 
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            string Quantity = "50";

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
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
            string Quantity = 10000.ToString();

            // invoke the method 
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreNotEqual(Error, "");

        }
        
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            string Price = 0.ToString();

            // invoke the method 
            Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            // test to see that result is ok , e, g - There shold be an error message 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PriceMinBoundary()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            string Price = 0.20m.ToString();

            // invoke the method 
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
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
            string Price = 2m.ToString();

            // invoke the method 
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
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
            string Price = 10000m.ToString();

            // invoke the method 
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
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
            string Price = 20001m.ToString();

            // invoke the method 
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PriceMid()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation 
            String Error = "";
            // create some test data to the test method
            string Price = 10000m.ToString();

            // invoke the method 
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
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
            string Price = 100000m.ToString();

            // invoke the method 
             Error = AnOrder.Valid(Quantity, Price, PurchasedDate, InventoryId);
            // test to see that result is ok , e, g - There should be an error message 
            Assert.AreNotEqual(Error, "");

        }

    }
}
