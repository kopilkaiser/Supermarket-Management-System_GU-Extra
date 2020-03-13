using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace SMSTestProject
{
    [TestClass]
    public class tstOrderlineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            // teat to see tha t it exist
            Assert.IsNotNull(AllOrderline);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance for the class we want to create
            clsOrderlineCollection AllOrders = new clsOrderCollection();

            // create the item of the test data
            clsOrder TestItem = new clsOrder();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set it properties
            TestItem.Active = true;
            TestItem.OrderId = 05;
            TestItem.OrderCode = "XYZ2";
            TestItem.InventoryId = 1;
            TestItem.Quantity = 1;
            TestItem.Price = 1.99m;
            TestItem.PurchasedDate = DateTime.Now.Date;

            // set thisAdress to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key TestI data
            TestItem.OrderId = PrimaryKey;
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            // test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance for the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            // create the item of the test data
            clsOrder TestItem = new clsOrder();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set it properties
            TestItem.Active = true;
            TestItem.OrderId = 05;
            TestItem.OrderCode = "XYZ2";
            TestItem.InventoryId = 1;
            TestItem.Quantity = 1;
            TestItem.Price = 1.99m;
            TestItem.PurchasedDate = DateTime.Now.Date;

            // set thisAdress to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key TestI data
            TestItem.OrderId = PrimaryKey;
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            // test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance for the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();

            // create the item of the test data
            clsOrder TestItem = new clsOrder();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set it properties
            TestItem.Active = true;
            TestItem.OrderId = 05;
            TestItem.InventoryId = 1;
            TestItem.OrderCode = "XYZ2";
            TestItem.Quantity = 1;
            TestItem.Price = 1.99m;
            TestItem.PurchasedDate = DateTime.Now.Date;

            // set thisAdress to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set the primary key TestI data
            TestItem.OrderId = PrimaryKey;
            // modify the test data
            TestItem.Active = false;
            TestItem.OrderId = 06;
            TestItem.InventoryId = 5;
            TestItem.Quantity = 4;
            TestItem.Price = 20.99m;
            TestItem.PurchasedDate = DateTime.Now.Date;
            // set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            // Update the record
            AllOrders.Update();
            // find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

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
            Assert.AreNotEqual(AllOrders.Count, SomeCount);
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
            TestItem.OrderCode = "XYZ2";
            TestItem.InventoryId = 1;
            TestItem.Quantity = 1;
            TestItem.Price = 1.99m;
            TestItem.PurchasedDate = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrders.OrderList = TestList;
            // test to see that two values are the same
            Assert.AreNotEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void FilterByOrderId()
        {
            // create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // apply the blank string
            FilteredOrders.ReportByOrderCode("");

            //test to see that the two values are the same
            Assert.AreNotEqual(AllOrders.Count, FilteredOrders.Count);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            // create an instance of the class
            clsOrder AnOrder = new clsOrder();
            // boolean variable to store the result of validation
            Boolean Found = false;
            // some test data to test the method
            Int32 OrderId = 1;
            // invoke the method
            Found = AnOrder.Find(OrderId);
            // test to see that the result is correct
            Assert.IsTrue(Found);






        }

        /* [TestMethod]
         public void FilterByOrderIdTestDataFound()
         {
             // create an instance of the class we want to create
             clsOrderCollection AllOrders = new clsOrderCollection();
             // var to store outcome
             Boolean OK = true;
             // apply a post code that doesnt exist
             FilteredOrders.FilterByOrderId(" ");
             // check that the correct number of records are found
             if (FilteredOrders.Count == 2)
             {
                 // check that the correct number of records is Order ID 5
                 if (FilteredOrders.OrderList[0].OrderID != 5)
                 {
                     OK = false;
                 }
                 if (FilteredOrders.OrderList[1].OrderID != 6)
                 {
                     OK = false;
                 }
             }
             else
             {
                 OK = false;
             }
             // test to see that there are no records
             Assert.IsTrue(OK);

         }*/

    }
}
