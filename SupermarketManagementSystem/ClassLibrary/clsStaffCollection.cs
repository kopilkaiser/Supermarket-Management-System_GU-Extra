using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisInventory
        clsStaff mThisStaff = new clsStaff();
        clsDataConnection dBConnection = new clsDataConnection();
        //dBConnection = new clsDataConnection();

        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblAccount_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection dB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = dBConnection.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                AnStaff.AccountNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["AccountNo"]);
                AnStaff.AccountEmail = Convert.ToString(dBConnection.DataTable.Rows[Index]["AccountEmail"]);
                AnStaff.AccountPassword = Convert.ToString(dBConnection.DataTable.Rows[Index]["AccountPassword"]);
                AnStaff.IsAdmin = Convert.ToBoolean(dBConnection.DataTable.Rows[Index]["IsAdmin"]);
                AnStaff.Active = Convert.ToBoolean(dBConnection.DataTable.Rows[Index]["Active"]);
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }

        }

        public clsStaff ThisStaff
        {
            get
            {
                //return this private data
                return mThisStaff;
            }

            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            dBConnection = new clsDataConnection();
            //add a new record to the database based on the values of ThisStaff
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            dBConnection.AddParameter("@AccountEMail", mThisStaff.AccountEmail);
            dBConnection.AddParameter("@AccountPassword", mThisStaff.AccountPassword);
            //dBConnection.AddParameter("@IsAdmin", mThisStaff.IsAdmin);
            dBConnection.AddParameter("@Active", mThisStaff.Active);
            //execute the query returning the primary key value
            return dBConnection.Execute("sproc_tblAccount_Add");
        }

        public void Delete()
        {
            //delete the record pointed to by thisAddress();
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            dBConnection = new clsDataConnection();
            //set the parameters for the stored procedure
            dBConnection.AddParameter("@AccountNo", mThisStaff.AccountNo);
            //execute the stored procedure
            dBConnection.Execute("sproc_tblAccount_Delete");
        }

        public void Update()
        {
            dBConnection = new clsDataConnection();
            //update an existing record based on the values of thisStaff
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            dBConnection.AddParameter("@AccountEmail", mThisStaff.AccountEmail);
            dBConnection.AddParameter("@AccountPassword", mThisStaff.AccountPassword);
            dBConnection.AddParameter("@IsAdmin", mThisStaff.IsAdmin);
            dBConnection.AddParameter("@Active", mThisStaff.Active);
            //execute the stored procedure
            dBConnection.Execute("sproc_tblStaff_Update");
        }
    }
}