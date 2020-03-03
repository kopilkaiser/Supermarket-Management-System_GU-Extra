using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstPaymentByCustomer
    {
        //good test data
        //testdata to pass the method
        int PaymentId = 1;
        string Amount = 20.00m.ToString();
        string Method = "Debit Card";
        string PaymentDate = DateTime.Now.Date.ToString();
        int StaffId = 1;

        [TestMethod]
        public void InstanceOK()
        {
            //create an intance of class payment
            clsPayment AnPayment = new clsPayment();
            //test to see that exist
            Assert.IsNotNull(AnPayment);
        }
        [TestMethod]
        public void PaymentMethodProperty()
        {
            //create an instance of class payment
            clsPayment AnPayment = new clsPayment();
            //create variable for test data
            String Method = "Debit Card";
            //assign the value to the property
            AnPayment.Method = Method;
            //test to see that exist
            Assert.AreEqual(AnPayment.Method, Method);
        }

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            //create an instance of class payment
            clsPayment AnPayment = new clsPayment();
            //create variable for test data
            DateTime PaymentDate = DateTime.Now.Date;
            //assign the value to the property
            AnPayment.PaymentDate = PaymentDate;
            //test to see that exist
            Assert.AreEqual(AnPayment.PaymentDate, PaymentDate);
        }

        [TestMethod]
        public void PaymentAmountPropertyOK()
        {
            //create an instance of class payment 
            clsPayment AnPayment = new clsPayment();
            decimal Amount = 20.00m;
            AnPayment.Amount = Amount;
            //test to see that exist
            Assert.AreEqual(AnPayment.Amount, Amount);
        }

        [TestMethod]
        public void ValidMethod()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create a string variable to store the result of the that validation
            String Error = "";
            //create some test to assign the property
            string Amount = 20.00m.ToString();
            //create test to assign to the property
            string Method = "Visa Debit";
            //invoke the method
            Error = AnPayment.Valid(Method, Amount, PaymentDate);
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void PaymentMethodMinLessone()
        {
            //create an instance of cls payment 
            clsPayment AnPayment = new clsPayment();
            //create a string variable to strore the result of the validation
            string Error = "";
            //create some test data to the test method
            string Method = "";
            //invoke the method
            Error = AnPayment.Valid(Method, Amount, PaymentDate);
            //test to see the result is NOT OK i.e. there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMiniBoundary()
        {
            //create an instance of cls payment
            clsPayment AnPayment = new clsPayment();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to the test method 
            string Method = "V";
            //invoke the method
            Error = AnPayment.Valid(Method, Amount, PaymentDate);
            //test to see the result ok
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PaymentMethodMiniPlusOne()
        {
            //create an instance of cls payment
            clsPayment AnPayment = new clsPayment();
            //create a string variable to store the result of the validation
            string Error = "";
            //invoke the method
            Error = AnPayment.Valid(Method, Amount, PaymentDate);
            //test to see the result is ok i.e. there should be no error method
            Assert.AreEqual(Error, "");
        }
        /*[TestMethod]
        public void PaymentMethodMaxBoundary()
        {
            //create an instance of cls payment
            clsPayment AnPayment = new clsPayment();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to the test method
            string Method = "";
        }*/
    }
}

