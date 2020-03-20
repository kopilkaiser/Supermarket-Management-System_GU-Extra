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

        clsDataConnection dBConnection = new clsDataConnection();


        // constructor for the ClsOrderCollection class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }
        //public property for the address list
        public List<clsOrder> OrderList
        {


            get
            {
                List<clsOrder> mOrderList = new List<clsOrder>();
                Int32 Index = 0;
                while (Index < dBConnection.Count)
                {
                    clsOrder NewOrder = new clsOrder();
                    //get the house no from the query results
                    NewOrder.OrderId = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderId"]);
                    NewOrder.Email = Convert.ToString(dBConnection.DataTable.Rows[Index]["Email"]);
                    //get the street from the query results

                    NewOrder.CardNumber = Convert.ToString(dBConnection.DataTable.Rows[Index]["CardNumber"]);
                    //get the post code from the query results
                    NewOrder.PurchasedDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["PurchasedDate"]);

                    //increment the index
                    Index++;
                    //add the address to the list
                    mOrderList.Add(NewOrder);
                }
                //return the list of addresses
                return mOrderList;
            }

            set
            {
                mOrderList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return the count of the list
                return dBConnection.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                //return this private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            dBConnection = new clsDataConnection();
            //add a new record to the database based on the values of ThisInventory
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure

            dBConnection.AddParameter("@Email", mThisOrder.Email);
            dBConnection.AddParameter("@PurchasedDate", mThisOrder.PurchasedDate);
            dBConnection.AddParameter("@CardNumber", mThisOrder.CardNumber);

            //execute the query returning the primary key value
            return dBConnection.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisOrder();
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            dBConnection = new clsDataConnection();
            //set the parameters for the stored procedure
            dBConnection.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure
            dBConnection.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            dBConnection = new clsDataConnection();
            //update an existing record based on the values of thisOrder
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            dBConnection.AddParameter("@OrderId", mThisOrder.OrderId);
            dBConnection.AddParameter("@Email", mThisOrder.Email);
            dBConnection.AddParameter("@PurchasedDate", mThisOrder.PurchasedDate);
            dBConnection.AddParameter("@CardNumber", mThisOrder.CardNumber);

            //execute the stored procedure
            dBConnection.Execute("sproc_tblOrder_Update");
        }

       

        void PopulateArray(clsDataConnection dBConnection)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = dBConnection.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderId = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["OrderId"]);
                AnOrder.Email = Convert.ToString(dBConnection.DataTable.Rows[Index]["Email"]);
                AnOrder.PurchasedDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["PurchasedDate"]);
                AnOrder.CardNumber = Convert.ToString(dBConnection.DataTable.Rows[Index]["CardNumber"]);
               


               
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

        public void FilterByEmail(string Email)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            //send the Email parameter to the database
            dBConnection = new clsDataConnection();
            dBConnection.AddParameter("@Email", Email);
            //execute the stored procedure
            dBConnection.Execute("sproc_tblOrder_FilterByEmail");
            //populate the array list with the data table
            PopulateArray(dBConnection);
        }
    }
}









