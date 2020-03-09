using System;
using ClassLibrary;
using ClassLibrary.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstStaff
    {
        //some good test data
        int StaffID = 001;
        string Name = "Syed";
        string UserName = "syed123";
        string Password = "oranges541";
        string Department = "Cleaner";
        string StartingDate = DateTime.Now.Date.ToString();
        Boolean Active = true;

        [TestMethod]
        public void InteanceOK()
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
        public void NamePropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Name = "Syed";
            AnStaff.Name = Name;
            Assert.AreEqual(Name, AnStaff.Name);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string UserName = "syed123";
            AnStaff.UserName = UserName;
            Assert.AreEqual(UserName,  AnStaff.UserName);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Password = "oranges541";
            AnStaff.Password = Password;
            Assert.AreEqual(Password, AnStaff.Password);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Department = "Cleaner";
            AnStaff.Department = Department;
            Assert.AreEqual(Department, AnStaff.Department);
        }

        [TestMethod]
        public void StartingDatePropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            DateTime StartingDate = DateTime.Now.Date;
            AnStaff.StartingDate = StartingDate;
            Assert.AreEqual(StartingDate, AnStaff.StartingDate);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
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
            Int32 StaffID = 001;
            //invoke the method
            Found = AnStaff.Find(StaffID);
            //test to see that the result is correct
            Assert.IsFalse(Found);
        }

        ///////////////////////////////
        //TestMethods for Name property

        [TestMethod]
        public void NameExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NameMinBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "a";
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "aa";
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(79, 'a');
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(80, 'a');
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(81, 'a');
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(40, 'a');
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        ///////////////////////////////
        //TestMethods for UserName property

        [TestMethod]
        public void UserNameExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String UserName ="";
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMinMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String UserName ="";
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void UserNameMinBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "a";
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void UserNameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "aa";
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void UserNameMaxMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String UserName ="";
            UserName = UserName.PadRight(79, 'a');
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMaxBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String UserName ="";
            UserName = UserName.PadRight(80, 'a');
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String UserName ="";
            UserName = UserName.PadRight(81, 'a');
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UserNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String UserName ="";
            UserName = UserName.PadRight(40, 'a');
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UserNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String UserName ="";
            UserName = UserName.PadRight(500, 'a');
            Error = AnStaff.Valid(Name, UserName, Password, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

    }
}
