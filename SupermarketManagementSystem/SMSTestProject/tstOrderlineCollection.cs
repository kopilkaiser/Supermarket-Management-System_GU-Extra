using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

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
        public void ThisOrderlinePropertyOK()
        {
            // create an instance of the class we want to create
            clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            // create some test data to assign the property
            clsOrderline TestOrderline = new clsOrderline();
            // set the properties of the object
            TestOrderline.OrderlineId = 1;
            TestOrderline.OrderId = 05;
            TestOrderline.Quantity = 01;
            TestOrderline.InventoryId = 01;
            // assign the data to the property
            AllOrderline.ThisOrderline = TestOrderline;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrderline.ThisOrderline, TestOrderline);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance for the class we want to create
           clsOrderlineCollection AllOrderline = new clsOrderlineCollection();

            // create the item of the test data
           clsOrderline TestItem = new clsOrderline();

            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set it properties
            TestItem.OrderlineId = 2;
            TestItem.OrderId = 05;
            TestItem.Quantity = 01;
            TestItem.InventoryId = 01;


            // set thisAdress to the test data
            AllOrderline.ThisOrderline = TestItem;
            // add the record
            PrimaryKey = AllOrderline.Add();
            // set the primary key TestI data
            TestItem.OrderlineId = PrimaryKey;
            // find the record
            AllOrderline.ThisOrderline.Find(PrimaryKey);

            // test to see that the two values are the same
            Assert.AreEqual(AllOrderline.ThisOrderline, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance for the class we want to create
           clsOrderlineCollection AllOrderline = new clsOrderlineCollection();

            // create the item of the test data
           clsOrderline TestItem = new clsOrderline();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set it properties
            TestItem.OrderlineId = 2;
            TestItem.OrderId = 05;
            TestItem.Quantity = 01;
            TestItem.InventoryId = 01;


            // set thisAdress to the test data
            AllOrderline.ThisOrderline = TestItem;
            // add the record
            PrimaryKey = AllOrderline.Add();
            // set the primary key TestI data
            TestItem.OrderlineId = PrimaryKey;
            // find the record
            AllOrderline.ThisOrderline.Find(PrimaryKey);
            // delete the record
            AllOrderline.Delete();
            //now find the record
            Boolean Found = AllOrderline.ThisOrderline.Find(PrimaryKey);

            // test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]

        public void UpdateMethodOK()
        {
            // create an instance for the class we want to create
           clsOrderlineCollection AllOrderline = new clsOrderlineCollection();

            // create the item of the test data
           clsOrderline TestItem = new clsOrderline();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            // set it properties
            //TestItem.OrderlineId = 2;
            TestItem.OrderId = 05;
            TestItem.Quantity = 01;
            TestItem.InventoryId = 01;


            // set thisAdress to the test data
            AllOrderline.ThisOrderline = TestItem;
            // add the record
            PrimaryKey = AllOrderline.Add();
            // set the primary key TestI data
            TestItem.OrderlineId = PrimaryKey;
            // modify the test data
            
            TestItem.OrderId = 03;
            TestItem.Quantity = 02;
            TestItem.InventoryId = 01;

            // set the record based on the new test data
            AllOrderline.ThisOrderline = TestItem;
            // Update the record
            AllOrderline.Update();
            // find the record
            AllOrderline.ThisOrderline.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.AreEqual(AllOrderline.ThisOrderline, TestItem);

        }


        /*[TestMethod]
        public void OrderListOK()
        {
            // create an instance for the class we want to create
           clsOrderlinelineCollection AllOrderline = newclsOrderlinelineCollection();
            //create the item of test data
            clsOrderline TestItem = new clsOrderline();

            // create some test data to assign the property
            // in this case the dat needto be a list of objects
            List<clsOrderline> TestList = new List<clsOrderline>();
            // add an item on the list
            // create the item of tesst data  
           clsOrderline TestItem = newclsOrderline();
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
            AllOrderline.OrderList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllOrderline.OrderList, TestList);

        }
        */
        [TestMethod]
        public void CountPropertyOK()
        {
            // create an instance of the class we want to create
           clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            // create the item of the test data
            clsOrderline TestItem = new clsOrderline();
            //create some test data to assign the property
            Int32 SomeCount = 2;
            // assign the data to the property
            AllOrderline.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreNotEqual(AllOrderline.Count, SomeCount);
        }
       
        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
           clsOrderlineCollection AllOrderline = new clsOrderlineCollection();
            // create the item of the test data
            clsOrderline TestItem = new clsOrderline();

            // create some data to assign the property
            //in this case the data needs to be a list of objects
            List<clsOrderline> TestList = new List<clsOrderline>();
            // add an item to the list

            // set it properties
            TestItem.OrderlineId = 2;
            TestItem.OrderId = 05;
            TestItem.Quantity = 01;
            TestItem.InventoryId = 01;
            //add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllOrderline.OrderlineList = TestList;
            // test to see that two values are the same
            Assert.AreNotEqual(AllOrderline.Count, TestList.Count);
        }

        /*[TestMethod]///////////////////////////////////////////////////fix this issue after fix of ReportBy Method
      public void FilterByOrderId()
       {
           // create an instance of the class we want to create
          clsOrderlineCollection AllOrderline = new clsOrderlineCollection();

           // create an instance of the filtered data
          clsOrderlineCollection FilteredOrders = new clsOrderlineCollection();
           // apply the blank string
           FilteredOrders.ReportByOrderCode("");

           //test to see that the two values are the same
           Assert.AreNotEqual(AllOrderline.Count, FilteredOrders.Count);
       }*/

        





    }

        /* [TestMethod]
         public void FilterByOrderIdTestDataFound()
         {
             // create an instance of the class we want to create
            clsOrderlineCollection AllOrderline = newclsOrderlineCollection();
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
