using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsInventoryCollection
    {
        //private data member for the list
        List<clsInventory> mInventoryList = new List<clsInventory>();
        //private data member thisInventory
        clsInventory mThisInventory = new clsInventory();

        public clsInventoryCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblInventory_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }
        

        //public property for the address list
        public List<clsInventory> InventoryList
        {
            get
            {
                //return the private data
                return mInventoryList;
            }
            set
            {
                //set the private data
                mInventoryList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return the count of the list
                return mInventoryList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsInventory ThisInventory
        {
            get
            {
                //return this private data
                return mThisInventory;
            }
            set
            {
                //set the private data
                mThisInventory = value;
            }
        }

        public int Add()
        {
            //add a new record to the database based on the values of ThisInventory
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Name", mThisInventory.Name);
            DB.AddParameter("@Price", mThisInventory.Price);
            DB.AddParameter("@Quantity", mThisInventory.Quantity);
            DB.AddParameter("@Category", mThisInventory.Category);
            DB.AddParameter("@DateAdded", mThisInventory.DateAdded);
            DB.AddParameter("@Active", mThisInventory.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblInventory_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisAddress();
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@InventoryId", mThisInventory.InventoryId);
            //execute the stored procedure
            DB.Execute("sproc_tblInventory_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisInventory
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@InventoryId", mThisInventory.InventoryId);
            DB.AddParameter("@Name", mThisInventory.Name);
            DB.AddParameter("@Price", mThisInventory.Price);
            DB.AddParameter("@Quantity", mThisInventory.Quantity);
            DB.AddParameter("@Category", mThisInventory.Category);
            DB.AddParameter("@DateAdded", mThisInventory.DateAdded);
            DB.AddParameter("@Active", mThisInventory.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblInventory_Update");
        }

        public void ReportByCategory(string Category)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Category parameter to the database
            DB.AddParameter("@Category", Category);
            //execute the stored procedure
            DB.Execute("sproc_tblInventory_FilterByCategory");
            //populate the array list with the data table
            PopulateArray(DB);
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
            mInventoryList = new List<clsInventory>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsInventory AnInventory = new clsInventory();
                //read in the fields from the current record
                AnInventory.InventoryId = Convert.ToInt32(DB.DataTable.Rows[Index]["InventoryId"]);
                AnInventory.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnInventory.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnInventory.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnInventory.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnInventory.Category = Convert.ToString(DB.DataTable.Rows[Index]["Category"]);
                AnInventory.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mInventoryList.Add(AnInventory);
                //point at the next record
                Index++;
            }
        }
    }
}