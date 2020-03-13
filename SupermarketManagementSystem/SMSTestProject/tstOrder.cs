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
        string AccountNo = "2";
        string PaymentId = "3";
        string PurchasedDate = DateTime.Now.ToString();
        

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // test to see that it exist
            Assert.IsNotNull(AnOrder);
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
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            // test to see that result is ok , e, g - There are no error message
            Assert.AreEqual(Error, "");

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
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
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
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PurchasedDateMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string PurchasedDate = DateTime.Now.Date.ToString();
            string Error = "";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
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
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PurchasedDateInvalidDataType()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PurchasedDate = "a";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }
    }
}  

