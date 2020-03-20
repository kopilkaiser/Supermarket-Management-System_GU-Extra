using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstStaff
    {
        //some good test data
        int StaffId = 1;
        string AccountNo = "1";
        string Name = "Syed";
        string Phonenum = "123456789123";
        string DateJoined = DateTime.Now.Date.ToString(); 
        Boolean Active = true;

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
        public void PhonenumPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Phonenum = "123456789123";
            AnStaff.Phonenum = Phonenum;
            Assert.AreEqual(Phonenum, AnStaff.Phonenum);
        }

        [TestMethod]
        public void AccountNoPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            int AccountNo = 12;
            AnStaff.AccountNo = AccountNo;
            Assert.AreEqual(AccountNo, AnStaff.AccountNo);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Name = "Syed";
            AnStaff.Name = Name;
            Assert.AreEqual(Name, AnStaff.Name);
        }

        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            DateTime DateJoined = DateTime.Now.Date;
            AnStaff.DateJoined = DateJoined;
            Assert.AreEqual(DateJoined, AnStaff.DateJoined);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string AccountNo = 1.ToString();
            string DateJoined = DateTime.Now.Date.ToString();
            Error = AnStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
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
            int StaffId = 1;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        ///////////////////////////////
        //TestMethods for AccountNo property

        [TestMethod]
        public void AccountNoExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string AccountNo = "";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountNoMinMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string AccountNo = "";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AccountNoMinBoundary()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string AccountNo = "9";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AccountNoMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string AccountNo = "99";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AccountNoMaxMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string AccountNo = "9999";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNoMaxBoundary()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string AccountNo = "10000";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNoMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string AccountNo = "10001";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountNoMid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string AccountNo = "5000";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNoExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string AccountNo = "500000";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        ///////////////////////////////
        //TestMethods for Name property

        [TestMethod]
        public void NameExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NameMinBoundary()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "a";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "aa";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(49, 'a');
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxBoundary()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(50, 'a');
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(51, 'a');
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(25, 'a');
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(100, 'a');
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        ///////////////////////////////
        //TestMethods for Phonenum property

        [TestMethod]
        public void PhonenumExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Phonenum = "";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumMinMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Phonenum = "";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PhonenumMinBoundary()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Phonenum = "1";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhonenumMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Phonenum = "12";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhonenumMaxMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Phonenum = "12345678912345";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumMaxBoundary()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Phonenum = "123456789123456";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Phonenum = "1234567891234567";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumMid()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Phonenum = "1234567896";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string Phonenum = "123456789123456789";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        ///////////////////////////////
        //TestMethods for DateJoined property

        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(-100);
            string DateJoined = TestDate.ToString();
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMinMinusOne()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddDays(-1);
            string DateJoined = TestDate.ToString();
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateJoinedMinBoundary()
        {
            clsStaff AStaff = new clsStaff();
            string DateJoined = DateTime.Now.Date.ToString();
            string Error = "";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateJoinedExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(100);
            string DateJoined = TestDate.ToString();
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateJoinedInvalidDataType()
        {
            clsStaff AStaff = new clsStaff();
            string Error = "";
            string DateJoined = "a";
            Error = AStaff.Valid(AccountNo, Name, Phonenum, DateJoined);
            Assert.AreNotEqual(Error, "");
        }
    }
}
