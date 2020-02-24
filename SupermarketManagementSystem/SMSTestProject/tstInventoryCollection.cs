using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SMSTestProject
{
    [TestClass]
    public class tstInventoryCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //test to see that it exists
            Assert.IsNotNull(AllInventories);
        }

        [TestMethod]
        public void InventoryListOK()
        {
            //create an instance of the class we want to create
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsInventory> TestList = new List<clsInventory>();
            //add an item to the list
            //create the item of test data
            clsInventory TestItem = new clsInventory();
            //set it's properties
            TestItem.Active = true;
            TestItem.Name = "Samsung OLED TV";
            TestItem.Price = 2999.99m;
            TestItem.Quantity = 100;
            TestItem.Category = "Electronics";
            TestItem.DateAdded = DateTime.Now.Date.ToString();
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllInventories.InventoryList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllInventories.InventoryList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllInventories.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllInventories.Count, SomeCount);
        }

        [TestMethod]
        public void ThisInventoryPropertyOK()
        {
            //create the instance of the class we want to create
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //create some test data to assign to the property
            clsInventory TestInventory = new clsInventory();
            //set the properties of the test object
            TestInventory.Active = true;
            TestInventory.Name = "Samsung OLED TV";
            TestInventory.Price = 2999.99m;
            TestInventory.Quantity = 100;
            TestInventory.Category = "Electronics";
            TestInventory.DateAdded = DateTime.Now.Date.ToString();
            //assign the data to the property
            AllInventories.ThisInventory = TestInventory;
            //test to see that the two values are the same;
            Assert.AreEqual(AllInventories.ThisInventory, TestInventory);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsInventory> TestList = new List<clsInventory>();
            //add an item to the list
            //create the item of test data
            clsInventory TestItem = new clsInventory();
            //set it's properties
            TestItem.Active = true;
            TestItem.Name = "Samsung OLED TV";
            TestItem.Price = 2999.99m;
            TestItem.Quantity = 100;
            TestItem.Category = "Electronics";
            TestItem.DateAdded = DateTime.Now.Date.ToString();
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllInventories.InventoryList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllInventories.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllInventories.Count, 2);
        }
    }
}
