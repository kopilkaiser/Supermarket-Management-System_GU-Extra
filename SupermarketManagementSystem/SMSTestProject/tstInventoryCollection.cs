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
            TestItem.InventoryId = 1;
            TestItem.Active = true;
            TestItem.Name = "Samsung OLED TV";
            TestItem.Price = 2999.99m;
            TestItem.Quantity = 100;
            TestItem.Category = "Electronics";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllInventories.InventoryList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllInventories.InventoryList, TestList);
        }


        [TestMethod]
        public void ThisInventoryPropertyOK()
        {
            //create the instance of the class we want to create
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //create some test data to assign to the property
            clsInventory TestInventory = new clsInventory();
            //set the properties of the test object
            TestInventory.InventoryId = 1;
            TestInventory.Active = true;
            TestInventory.Name = "Samsung OLED TV";
            TestInventory.Price = 2999.99m;
            TestInventory.Quantity = 100;
            TestInventory.Category = "Electronics";
            TestInventory.DateAdded = DateTime.Now.Date;
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
            TestItem.InventoryId = 1;
            TestItem.Active = true;
            TestItem.Name = "Samsung OLED TV";
            TestItem.Price = 2999.99m;
            TestItem.Quantity = 100;
            TestItem.Category = "Electronics";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllInventories.InventoryList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllInventories.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //create the item of test data
            clsInventory TestItem = new clsInventory();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.InventoryId = 1;
            TestItem.Active = true;
            TestItem.Name = "Samsung OLED TV";
            TestItem.Price = 2999.99m;
            TestItem.Quantity = 100;
            TestItem.Category = "Electronics";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisAddress to the test data
            AllInventories.ThisInventory = TestItem;
            //add the record
            PrimaryKey = AllInventories.Add();
            //set the primary key of the test data
            TestItem.InventoryId = PrimaryKey;
            //find the record
            AllInventories.ThisInventory.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllInventories.ThisInventory, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsInventoryCollection AllInventories = new clsInventoryCollection();
            //create the item of test data
            clsInventory TestItem = new clsInventory();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.InventoryId = 1;
            TestItem.Active = true;
            TestItem.Name = "Samsung OLED TV";
            TestItem.Price = 2999.99m;
            TestItem.Quantity = 100;
            TestItem.Category = "Electronics";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisAddress to the test data
            AllInventories.ThisInventory = TestItem;
            //add the record
            PrimaryKey = AllInventories.Add();
            //set the primary key of the test data
            TestItem.InventoryId = PrimaryKey;
            //find the record
            AllInventories.ThisInventory.Find(PrimaryKey);
            //delete the record
            AllInventories.Delete();
            //now find the record
            Boolean Found = AllInventories.ThisInventory.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }
    }
}
