using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstStaff
    {
        //some good test data
        int AccountNo = 1;
        string AccountEmail = "cc@email.com";
        string AccountPassword = "1234567";
        Boolean IsAdmin = false;
        Boolean Active = true;
        string TempPW = "";

        [TestMethod]
        public void InstanceOK()
        {
            //create an intance of the class
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Active, TestData);
        }

        [TestMethod]
        public void IsAdminPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = false;
            //assign the data to the property
            AnStaff.IsAdmin = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.IsAdmin, TestData);
        }

        [TestMethod]
        public void AccountEmailPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string AccountEmail = "cc@email.com";
            AnStaff.AccountEmail = AccountEmail;
            Assert.AreEqual(AccountEmail, AnStaff.AccountEmail);
        }

        [TestMethod]
        public void AccountPasswordPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string AccountPassword = "1234567";
            AnStaff.AccountPassword = AccountPassword;
            Assert.AreEqual(AccountPassword, AnStaff.AccountPassword);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int AccountNo = 1;
            //invoke the method
            Found = AnStaff.Find(AccountNo);
            //test to see that the result is correct
            Assert.IsFalse(Found);
        }

        ///////////////////////////////
        //TestMethods for AccountEmail property

        [TestMethod]
        public void AccountEmailExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountEmail = "";
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountEmailMinMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountEmail = "";
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AccountEmailMinBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountEmail = "a";
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AccountEmailMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountEmail = "aa";
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountEmail = "";
            AccountEmail = AccountEmail.PadRight(79, 'a');
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountEmailMaxBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountEmail = "";
            AccountEmail = AccountEmail.PadRight(80, 'a');
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountEmailMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountEmail = "";
            AccountEmail = AccountEmail.PadRight(81, 'a');
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountEmailMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountEmail = "";
            AccountEmail = AccountEmail.PadRight(40, 'a');
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountEmailExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountEmail = "";
            AccountEmail = AccountEmail.PadRight(500, 'a');
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreNotEqual(Error, "");
        }

        ///////////////////////////////
        //TestMethods for AccountPassword property

        [TestMethod]
        public void AccountPasswordExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountPassword = "";
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountPasswordMinMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountPassword = "";
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AccountPasswordMinBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountPassword = "a";
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AccountPasswordMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountPassword = "aa";
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AccountPasswordMaxMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountPassword = "";
            AccountPassword = AccountPassword.PadRight(79, 'a');
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountPasswordMaxBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountPassword = "";
            AccountPassword = AccountPassword.PadRight(80, 'a');
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountPasswordMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountPassword = "";
            AccountPassword = AccountPassword.PadRight(81, 'a');
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountPasswordMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountPassword = "";
            AccountPassword = AccountPassword.PadRight(40, 'a');
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountPasswordExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountPassword = "";
            AccountPassword = AccountPassword.PadRight(500, 'a');
            Error = AnStaff.Valid(AccountEmail, AccountPassword);
            Assert.AreNotEqual(Error, "");
        }
    }
}
