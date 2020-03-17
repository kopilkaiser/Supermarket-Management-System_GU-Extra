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
        string Email = "A@gmail.com";
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
        public void EmailPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string Email = "S@gmail.com";
            AnOrder.Email = Email;
            Assert.AreEqual(Email, AnOrder.Email);
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
            string Email = "k@gmail.com";
            // create some test data to asign the property
            string PaymentId = 10.ToString();
            string PurchasedDate = DateTime.Now.Date.ToString();
            // invoke the method
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
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
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
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
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PurchasedDateMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string PurchasedDate = DateTime.Now.Date.ToString();
            string Error = "";
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
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
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PurchasedDateInvalidDataType()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PurchasedDate = "a";
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }
        /// <summary>
        /// ////////////
        /// </summary>
        /// // testing foremail
         [TestMethod]
        public void EmailExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "";
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "";
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "aaaaaaaaaa";
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "aaaaaaaaaaa";
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'a');
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "";
            Email = Email.PadRight(50, 'a');
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "";
            Email = Email.PadRight(51, 'a');
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "";
           Email =Email.PadRight(25, 'a');
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "";
           Email =Email.PadRight(100, 'a');
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
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
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMinMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "";
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PaymentIdMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "1";
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PaymentIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "2";
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PaymentIdMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "9999";
            
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMaxBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "10000";
            
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "10001";
            
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "5000";
           
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PaymentId = "500000";
            
            Error = AnOrder.Valid(Email, PaymentId, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }
    }

}  

