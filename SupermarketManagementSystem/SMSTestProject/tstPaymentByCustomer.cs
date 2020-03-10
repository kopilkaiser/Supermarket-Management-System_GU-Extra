using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
   /* [TestClass]
    public class tstPaymentByCustomer
    {
        //good test data
        //testdata to pass the method

        int PaymentId = 1;
        string Name = "Cadbury";
        string Category = "Electronics";
        string Amount = 20.00m.ToString();
        string Method = "Debit Card";
        string PaymentDate = DateTime.Now.Date.ToString();
        int StaffId = 1;
        int CardNumber = 9999999999999999;


        [TestMethod]
        public void InstanceOK()
        {
            //create an intance of class payment
            clsPayment AnPayment = new clsPayment();
            //test to see that exist
            Assert.IsNotNull(AnPayment);
        }
        [TestMethod]
        public void SuccessPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            Boolean TestData = true;
            AnPayment.Success = TestData;
            Assert.AreEqual(AnPayment.Success, TestData);
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
        public void NamePropertyOK()
        {
            //create an instance of cls payment
            clsPayment AnPayment = new clsPayment();
            string Name = "Cadbury";
            AnPayment.Name = Name;
            Assert.AreEqual(AnPayment.Name, Name);
        }
        [TestMethod]
        public void CategoryPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            string Category = "Electronics";
            AnPayment.Category = Category;
            Assert.AreEqual(AnPayment.Category, Category);
        }
        [TestMethod]
        public void CardNumberPropertyOK()
        {
            clsPayment AnPayment = new clsPayment();
            Int64 CardNumber = 450456012578;
            AnPayment.CardNumber = CardNumber;
            Assert.AreEqual(AnPayment.CardNumber, CardNumber);
        }
        [TestMethod]
        public void AmountPropertyOK()
        {
            //create an instance of class payment 
            clsPayment AnPayment = new clsPayment();
            decimal Amount = 20.00m;
            AnPayment.Amount = Amount;
            //test to see that exist
            Assert.AreEqual(AnPayment.Amount, Amount);
        }
        [TestMethod]
        public void DatePropertyOK()
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
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsPayment AnPayment = new clsPayment();
            Boolean Found = false;
            Int32 PaymentId = 4;
            Found = AnPayment.Find(PaymentId);
            Assert.IsTrue(Found);
        }

        //TestMethod for Date Property by different test types and test data//

        [TestMethod]
        public void DateExtremeMin()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            DateTime = TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(-100);
            string Date = TestDate.ToString();
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateMiniMinusOne()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddDays(-1);
            string Date = TestDate.ToString();
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateMinBoundary()
        {
            clsPayment AnPayment = new clsPayment();
            string Date = DateTime.Now.Date.ToString();
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateExtremeMax()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(100);
            string Date = TestDate.ToString();
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateInvalidDateType()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            string Date = 'A';
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }

        // Test Methods for Name Property by different test types and test data//
        [TestMethod]
        public void NameExtrmeMin()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            string Name = "";
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMinMinusOne()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            string Name = "";
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMinBoundary()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            string Error = "";
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        
        }
        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(80, 'a');
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NameMaxBoundary()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(81, 'a');
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsPayment AnPayment = clsPayment();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(82,'a');
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(40, 'a');
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameExtreMax()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }

        //TestMethods for Method Property by different test types and test data//

        [TestMethod]
        public void MethodMinLessone()
        {
            //create an instance of cls payment 
            clsPayment AnPayment = new clsPayment();
            //create a string variable to strore the result of the validation
            string Error = "";
            //create some test data to the test method
            string Method = "";
            //invoke the method
            Error = AnPayment.Valid(Name, Category, CardNumber, Method, Amount, PaymentDate);
            //test to see the result is NOT OK i.e. there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MethodMiniBoundary()
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
        public void MethodMiniPlusOne()
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
        [TestMethod]
        public void MethodMaxBoundary()
        {
            //create an instance of cls payment
            clsPayment AnPayment = new clsPayment();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to the test method
            string Method = "";
            //oad the string with 30 characters
            //this should pass
            Method = Method.PadRight(30, 'a');
            //invok the method
            Error = AnPayment.Valid(Method, Amount, PaymentDate);
            //test to see teh result is OK i.e. there should be no error message
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MethodMaxPlusOne()
        {
            //create an instance of cls payment 
            clsPayment AnPayment = new clsPayment();
            //create a string variable to store teh result of the validation
            string Error = "qwertyuiopasdfghklzxcvbnm01234";
            //invok the method
            Error = AnPayment.Valid(Method, Amount, PaymentDate);
            //the result is OK;
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MethodMid()
        {
            //create an instance of cls payment
            clsPayment AnPayment = new clsPayment();
            //create a string to store the result of the validation
            string Error = "";
            //create some test data to the test method
            string Method = "qwertyuiopasd12";
            //invok the method
            Error = AnPayment.Valid(Method, Amount, PaymentDate);
            //test to see the result is ok
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MethodExtrmeMax()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            string Method = "aefueownvpqubfienakdpqneinviap15";
            Error = AnPayment.Valid(Name, Category, CardNumber, Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void MethodExtrmeMin()
        {
            clsPayment AnPayment = new clsPayment();
            string Error = "";
            string Method = "aaaeeevvvwww1";
            Error = AnPayment.Valid( Amount, Method, PaymentDate);
            Assert.AreNotEqual(Error, "");
        }
        //TestMethods for Amount by different test types and data//

        [TestMethod]
        public void AmountExtremeMax()
        {
            //create an instance of cls payment 
            clsPayment AnPayment = new clsPayment();
            //create a string variable to store the result of validation
            string Error = "";
            //create some test data to test the method
            string Amount = 10000000m.ToString();
            //invoke the method
            Error = AnPayment.Valid(Method, Amount, PaymentDate);
            //the result is NOT OK, in example there should be an error message
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AmountMaxPlusOne()
        {
            //create an instance of class payment
            clsPayment AnPayment = new clsPayment();
            //create a string variable to store the result of the validation
            string Error = "";
            //create some test data to the test method
            string Amount = 10000001m.ToString();
            //invok the method
            Error = AnPayment.Valid(Method, Amount, PaymentDate);
            //the  result is NOT OK; in example there should be an error message
            Assert.AreNotEqual(Error, "");
        }
    }
}
