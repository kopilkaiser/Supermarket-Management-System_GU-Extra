using System;
using System.Collections.Generic;

namespace ClassLibrary
{


    public class clsOrderCollection
    {
        // private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();
        // private data member thisAdsress
        clsOrder mThisOrder = new clsOrder();

        clsDataConnection DB = new clsDataConnection();


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
            //populate the array list with the data table 
            PopulateArray(DB);
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
                AnOrder.OrderCode = Convert.ToString(DB.DataTable.Rows[Index]["OrderCode"]);
                // Add the record to  the private data member
                mOrderList.Add(AnOrder);
                //point to the next record 
                Index++;

            }

            
        }

        public void Delete()
        {
            // deletes the record pointed  to by this Address 
            // connect to the database 
            clsDataConnection DB = new clsDataConnection();
            // set the parameter for the stored procedure 
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
          
        }

        public int Add()
        { 
            // adds a new record  to the database on the values of mThisOrder
            // set the primary key value of the new record
            // mThisOrder.OrderId = 12;
            clsDataConnection DB = new clsDataConnection();
            // set the parameter for the stored procedure 
            //DB.AddParameter("OrderId", mThisOrder.OrderId);
            DB.AddParameter("OrderCode", mThisOrder.OrderCode);
            DB.AddParameter("InventoryId", mThisOrder.InventoryId);
            DB.AddParameter("Quantity", mThisOrder.Quantity);
            DB.AddParameter("Price", mThisOrder.Price);
            DB.AddParameter("PurchasedDate", mThisOrder.PurchasedDate);
            DB.AddParameter("Active", mThisOrder.Active);
            

            // return the primary key of the new record 
            //return mThisOrder.OrderId;
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            // update an existing recordbased on thge values of thisOrdre
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stored procedure
            // set the parameter for the stored procedure 
            DB.AddParameter("OrderId", mThisOrder.OrderId);
            DB.AddParameter("InventoryId", mThisOrder.InventoryId);
            DB.AddParameter("Quantity", mThisOrder.Quantity);
            DB.AddParameter("Price", mThisOrder.Price);
            DB.AddParameter("PurchasedDate", mThisOrder.PurchasedDate);
            DB.AddParameter("Active", mThisOrder.Active);
            DB.AddParameter("OrderCode", mThisOrder.OrderCode);


           //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");

        }

        public void ReportByOrderCode(string OrderCode)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            //send the Category parameter to the database
            DB = new clsDataConnection();
            DB.AddParameter("@OrderCode", OrderCode);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderCode");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        // public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                // return the private data 
                return mThisOrder;
            }
            set
            {
                // set the private data
                mThisOrder = value;
            }
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
                return DB.Count;
            }
            set
            {

                // later on


            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.InventoryId = Convert.ToInt32(DB.DataTable.Rows[Index]["InventoryId"]);
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.PurchasedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PurchasedDate"]);
                AnOrder.OrderCode = Convert.ToString(DB.DataTable.Rows[Index]["OrderCode"]);

                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

       
    }

   
}