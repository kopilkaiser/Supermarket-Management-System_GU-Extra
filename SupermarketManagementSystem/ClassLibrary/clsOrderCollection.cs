using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    
    public class clsOrderCollection
    {
        // private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();


        // constructor for the ClsOrderCollection class
    public clsOrderCollection()
    {

            // var for the index 
            Int32 Index = 0;
            // var to store the record count 
            Int32 RecordCount = 0;
            //  object for data connection 
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            // get the count of records 
            RecordCount = DB.Count;
            // while there are records are process
            while (Index < RecordCount)
            {
                // create a blank Order
                clsOrder AnOrder = new clsOrder();
                // read in the fields from the current record 
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.InventoryId = Convert.ToInt32(DB.DataTable.Rows[Index]["InventoryId"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.PurchasedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PurchasedDate"]);
                // Add the record to  the private data member
                mOrderList.Add(AnOrder);
                //point to the next record 
                Index++;

            }
     /*
        // create the items of test data
        clsOrder TestItem = new clsOrder();
        // set its poperties 
        TestItem.Active = true;
        TestItem.OrderId = 1;
        TestItem.InventoryId = 1;
        TestItem.Quantity = 1;
        TestItem.Price = 1.99;
        TestItem.PurchasedDate = DateTime.Now.Date;
        // add the item to the test list 
        mOrderList.Add(TestItem);
       // re initialise the object for some new data 
        TestItem = new clsOrder();
        // sets its properties 
        TestItem.Active = true;
        TestItem.OrderId = 2;
        TestItem.InventoryId = 2;
        TestItem.Quantity = 2;
        TestItem.Price = 99;
        TestItem.PurchasedDate = DateTime.Now.Date;
        // add the item to the test list 
        mOrderList.Add(TestItem);
        */




        }
        //public property for the Order list
        public List<clsOrder> OrderList
        {
            get
            {
                // return the private data 
                return mOrderList;


            }
            set
            {
                // set the private data 
                mOrderList = value;


            }

        }
        //public property for the count 
        public int Count
        {
            get
            {
                // return the count of the list 
                return mOrderList.Count;
            }
            set
            {

                // later on


            }
        }

       //public List<clsOrder> OrderList { get; set; }
        //public int Count { get; set; }
        public clsOrder ThisOrder { get; set; }
    }
   
}