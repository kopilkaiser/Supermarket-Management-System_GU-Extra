using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstInventory
    {
        //some good test data
        int InventoryId = 1;
        string Name = "Cadbury";
        decimal Price = 6.99m;
        int Quantity = 999;
        string Category = "Electronics";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsInventory AnInventory = new clsInventory();
            Assert.IsNotNull(AnInventory);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsInventory AnInventory = new clsInventory();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnInventory.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnInventory.Active, TestData);
        }

        [TestMethod]
        public void InventoryIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsInventory AnInventory = new clsInventory();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnInventory.InventoryId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnInventory.InventoryId, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsInventory AnInventory = new clsInventory();
            string Name = "Cadbury";
            AnInventory.Name = Name;
            Assert.AreEqual(Name, AnInventory.Name);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsInventory AnInventory = new clsInventory();
            decimal Price = 5.99m;
            AnInventory.Price = Price;
            Assert.AreEqual(Price, AnInventory.Price);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsInventory AnInventory = new clsInventory();
            Int32 Quantity = 100;
            AnInventory.Quantity = Quantity;
            Assert.AreEqual(Quantity, AnInventory.Quantity);
        }

        [TestMethod]
        public void CategoryPropertyOK()
        {
            clsInventory AnInventory = new clsInventory();
            string Category = "Electronics";
            AnInventory.Category = Category;
            Assert.AreEqual(Category, AnInventory.Category);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsInventory AnInventory = new clsInventory();
            string DateAdded = DateTime.Now.Date.ToString();
            AnInventory.DateAdded = DateAdded;
            Assert.AreEqual(DateAdded, AnInventory.DateAdded);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        //TestMethods for DateAdded property by different test types and test data

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(-100);
            string DateAdded = TestDate.ToString();
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinMinusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddDays(-1);
            string DateAdded = TestDate.ToString();
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinBoundary()
        {
            clsInventory AnInventory = new clsInventory();
            string DateAdded = DateTime.Now.Date.ToString();
            string Error = "";
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(100);
            string DateAdded = TestDate.ToString();
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidDataType()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string DateAdded = "A";
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        //TestMethods for Name property by different test types and test data

        [TestMethod]
        public void NameExtremeMin()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Name = "";
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinMinusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Name = "";
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void NameMinBoundary()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Name = "a";
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Name = "aa";
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMaxMinusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(79, 'a');
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxBoundary()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(80, 'a');
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(81, 'a');
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(40, 'a');
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        //TestMethods for Category property by different test types and test data

        [TestMethod]
        public void CategoryExtremeMin()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "";
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMinMinusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "";
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CategoryMinBoundary()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "a";
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CategoryMinPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "aa";
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CategoryMaxMinusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "";
            Category = Category.PadRight(99, 'a');
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxBoundary()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "";
            Category = Category.PadRight(100, 'a');
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMaxPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "";
            Category = Category.PadRight(101, 'a');
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CategoryMid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "";
            Category = Category.PadRight(50, 'a');
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CategoryExtremeMax()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            string Category = "";
            Category = Category.PadRight(500, 'a');
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        //TestMethods for Price property by different Test Types and Test Data

        [TestMethod]
        public void PriceExtremeMin()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            decimal Price = -1m;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinMinusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            decimal Price = -1m;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PriceMinBoundary()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            decimal Price = 0m;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            decimal Price = 2m;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMaxMinusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            decimal Price = 99999m;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxBoundary()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            decimal Price = 100000m;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            decimal Price = 100001m;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            decimal Price = 50000m;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            decimal Price = 1000000m;          
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        //TestMethods for Quantity property with different test types and test data

        [TestMethod]
        public void QuantityExtremeMin()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            int Quantity = -1;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinMinusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            int Quantity = -1;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void QuantityMinBoundary()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            int Quantity = 0;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            int Quantity = 1;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMaxMinusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            int Quantity = 999;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxBoundary()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            int Quantity = 1000;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            int Quantity = 1001;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            int Quantity = 500;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            int Quantity = 5000;
           Error = AnInventory.Valid(InventoryId, Name, Price, Quantity, Category, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
    }
}
