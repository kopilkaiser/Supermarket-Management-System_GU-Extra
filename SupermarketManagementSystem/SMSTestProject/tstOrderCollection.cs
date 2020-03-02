﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SMSTestProject
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            // teat to see tha t it exist 
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            // create an instance for the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
           
            // create some test data to assign the property 
            // in this case the dat needto be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            // add an item on the list 
            // create the item of tesst data  
            clsOrder TestItem = new clsOrder();
            // set its properties 
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.InventoryId = 1;
            TestItem.Quantity = 1;
            TestItem.Price = 1.99m;
            TestItem.PurchasedDate = DateTime.Now.Date;
            // add the item to the test
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrders.OrderList = TestList;
            // test to see that the two values are the same 
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }
        [TestMethod]
        public void CountPropertyOK()
        {
            // create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign the property 
            Int32 SomeCount = 2;
            // assign the data to the property
            AllOrders.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.Count, SomeCount);

        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            // create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some test data to assign the property
            clsOrder TestOrder = new clsOrder();
            // set the properties of the object 
            TestOrder.Active = true;
            TestOrder.OrderId = 1;
            TestOrder.InventoryId = 1;
            TestOrder.Quantity = 1;
            TestOrder.Price = 1.99m;
            TestOrder.PurchasedDate = DateTime.Now.Date;
            // assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            // test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create some data to assign the property 
            //in this case the data needs to be a list of objects 
            List<clsOrder> TestList = new List<clsOrder>();
            // add an item to the list 
            // create the item of the test data
            clsOrder TestItem = new clsOrder();
            // set it properties
            TestItem.Active = true;
            TestItem.OrderId = 1;
            TestItem.InventoryId = 1;
            TestItem.Quantity = 1;
            TestItem.Price = 1.99m;
            TestItem.PurchasedDate = DateTime.Now.Date;
            //add the item to the test list 
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrders.OrderList = TestList;
            // test to see that two values are the same 
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        
      

    }
}

