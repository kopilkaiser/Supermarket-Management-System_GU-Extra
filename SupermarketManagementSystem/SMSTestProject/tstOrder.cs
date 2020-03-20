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
        string CardNumber = "5369852145632145";
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
            //assign the data to the property
            AnOrder.PurchasedDate = PurchasedDate;
            //test to see that it exist
            Assert.AreEqual(PurchasedDate, AnOrder.PurchasedDate);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            //test data to assign the property
            string Email = "S@gmail.com";

            AnOrder.Email = Email;
            // test to see that it exist
            Assert.AreEqual(Email, AnOrder.Email);
        }

        [TestMethod]
        public void CardNumberPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string CardNumber = 450456012578.ToString();
            AnOrder.CardNumber = CardNumber;
            Assert.AreEqual(AnOrder.CardNumber, CardNumber);
        }


        [TestMethod]
       
      
        public void OrderIdPropertyOK()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            int OrderId = 89063;
            AnOrder.OrderId = OrderId;
            //// test to see that it exist
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
            string CardNumber = "11111111111111";
            string PurchasedDate = DateTime.Now.Date.ToString();
            // invoke the method
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
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
            Error = AnOrder.Valid(Email, CardNumber, PurchasedDate);
            // test to see that it exist
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
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PurchasedDateMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string PurchasedDate = DateTime.Now.Date.ToString();
            string Error = "";
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
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
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PurchasedDateInvalidDataType()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string PurchasedDate = "a";
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }
        /// <summary>
        /// ////////////
        /// </summary>
        /// // testing for Email
         [TestMethod]
        public void EmailExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "";
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "aaaa";
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "aaaaa";
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "aaaaaaaaaaa";
            Error = AnOrder.Valid(Email, CardNumber, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'a');
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxBoundary()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "Anasaliaa535@gmail.com";
            Email = Email.PadRight(50, 'a');
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "Anasaliaa535@gmail.com";
            Email = Email.PadRight(51, 'a');
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "Anasaliaa535@gmail.com";
            Email =Email.PadRight(25, 'a');
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string Email = "Anasaliaa535@gmail.com";
            Email =Email.PadRight(100, 'a');
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        // testing for Card number
        /// <summary>
        /// //////////////
        /// </summary>
        [TestMethod]
        public void CardNumberExtremeMin()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CardNumber = "";
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMinMinusOne()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CardNumber = "111111111111";
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CardNumberMinBoundary()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CardNumber = "1111111111111";
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CardNumberMinPlusOne()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CardNumber = "11111111111111";
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CardNumberMaxMinusOne()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CardNumber = "111111111111111";
            
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CardNumberMaxBoundary()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CardNumber = "1111111111111111";
            //invoke the method 
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMaxPlusOne()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CardNumber = "11111111111111111";
            //invoke the method
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberMid()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CardNumber = "11111111";
           // invoke the method 
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberExtremeMax()
        {
            // create an instance for class Order
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string CardNumber = "111111111111111111111111111111111111";
            //invoke the method 
            Error = AnOrder.Valid(Email,CardNumber, PurchasedDate);

            Assert.AreNotEqual(Error, "");
        }
    }

}  

