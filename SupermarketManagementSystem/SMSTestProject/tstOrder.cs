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
        string AccountNo = "55";
        string PaymentId = "55";
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
        public void PurchasedDatePropertyOK()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            DateTime PurchasedDate = DateTime.Now.Date;
            AnOrder.PurchasedDate = PurchasedDate;
            Assert.AreEqual(PurchasedDate, AnOrder.PurchasedDate);
        }
        [TestMethod]
        public void AccountNoPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int AccountNo = 12345;
            AnOrder.AccountNo = AccountNo;
            Assert.AreEqual(AccountNo, AnOrder.AccountNo);
        }
        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            int OrderId = 89063;
            AnOrder.OrderId = OrderId;
            Assert.AreEqual(OrderId, AnOrder.OrderId);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of class Order
            clsOrder AnOrder = new clsOrder();
            // create an string variable to store the result of validation
            String Error = "";
            // create some test data to the test method
            string AccountNo = 1.ToString();
            // create some test data to asign the property
            string PaymentId = 10.ToString();
            string PurchasedDate = DateTime.Now.Date.ToString();
            // invoke the method
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            // test to see that result is ok , e, g - There are no error message
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see that the result is correct
            Assert.IsFalse(Found);
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
        /// <summary>
        /// ////////////
        /// </summary>
        /// // testing for account no
        [TestMethod]
        public void AccountNoExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountNoMinMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AccountNoMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "1";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AccountNoMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "2";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AccountNoMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "9999";
           
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNoMaxBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "10000";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNoMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "10001";
            
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountNoMid()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "5000";
      
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNoExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "5000000";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }
        // testing for payment Id
        /// <summary>
        /// //////////////
        /// </summary>
        [TestMethod]
        public void PaymentIdExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMinMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PaymentIdMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "1";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PaymentIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "2";
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PaymentIdMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "9999";
            
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMaxBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string AccountNo = "10000";
            
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "10001";
            
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "5000";
           
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "500000";
            
            Error = AnOrder.Valid(AccountNo, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }
    }

}  

