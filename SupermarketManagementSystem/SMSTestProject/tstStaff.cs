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
        int AccountNo = 1;
        Int64 Number = 99999999999;
        string Department = "Cleaner";
        string StartingDate = DateTime.Now.Date.ToString();
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
        public void NamePropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string Name = "Syed";
            AnStaff.Name = Name;
            Assert.AreEqual(Name, AnStaff.Name);
        }

        
        [TestMethod]
        public void NumberPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            Int64 Number = 99999999999;
            AnStaff.Number = Number;
            Assert.AreEqual(Number, AnStaff.Number);
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
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
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
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NameMinBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "a";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "aa";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(79, 'a');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(80, 'a');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(81, 'a');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(40, 'a');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }


        ///////////////////////////////
        //TestMethods for Number property

        [TestMethod]
        public void NumberExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Number = "";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberMinMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Number = "";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NumberMinBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Number = "9";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void NumberMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Number = "99";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void NumberMaxMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Number = "";
            Number = Number.PadRight(10, '9');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberMaxBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Number = "";
            Number = Number.PadRight(11, '9');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Number = "";
            Number = Number.PadRight(12, '9');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Number = "";
            Number = Number.PadRight(5, '9');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Number = "";
            Number = Number.PadRight(500, '9');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        ///////////////////////////////
        //TestMethods for Department property

        [TestMethod]
        public void DepartmentExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Department = "";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Department = "";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DepartmentMinBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Department = "a";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string Department = "aa";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DepartmentMaxMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Department = "";
            Department = Department.PadRight(79, 'a');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Department = "";
            Department = Department.PadRight(80, 'a');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Department = "";
            Department = Department.PadRight(81, 'a');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMid()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Department = "";
            Department = Department.PadRight(40, 'a');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            String Department = "";
            Department = Department.PadRight(500, 'a');
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        //TestMethods for StartingDate property

        [TestMethod]
        public void StartingDateExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(-100);
            string StartingDate = TestDate.ToString();
            Error = AnStaff.Valid(Name, Number, Department, this.StartingDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartingDateMinMinusOne()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddDays(-1);
            string StartingDate = TestDate.ToString();
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartingDateMinBoundary()
        {
            clsStaff AnStaff = new clsStaff();
            string StartingDate = DateTime.Now.Date.ToString();
            string Error = "";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StartingDateExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(100);
            string StartingDate = TestDate.ToString();
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartingDateInvalidDataType()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            string StartingDate = "a";
            Error = AnStaff.Valid(Name, Number, Department, StartingDate);
            Assert.AreNotEqual(Error, "");
        }



    }
}
