using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SMSTestProject
{
    [TestClass]
    public class tstInventory
    {
        //some good test data
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
            Error = AnInventory.Valid(Name, Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsInventory AnInventory = new clsInventory();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = DateTime.Now.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnInventory.Valid(Name,Price, Quantity, Category, DateAdded);
            Assert.AreEqual(Error, "");
        }
    }
}
