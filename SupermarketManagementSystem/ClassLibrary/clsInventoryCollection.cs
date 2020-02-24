using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsInventoryCollection
    {
        //private data member for the list
        List<clsInventory> mInventoryList = new List<clsInventory>();

        public clsInventoryCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblInventory_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
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
                AnInventory.DateAdded = Convert.ToString(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mInventoryList.Add(AnInventory);
                //point at the next record
                Index++;
            }
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
        public clsInventory ThisInventory { get; set; }
    }
}