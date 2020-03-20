using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsPaymentCollection
    {
        //private data member for the list 
        List<clsPayment> mPaymentList = new List<clsPayment>();
        //private data member this payment 
        clsPayment mThisPayment = new clsPayment();
        clsDataConnection dBConnection = new clsDataConnection();
        //dBConnection = new DataConnection();
        public clsPaymentCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //excecute the store procedure
            DB.Execute("sproc_tblPayment_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the payment list
        public List<clsPayment> PaymentList
        {
            get
            {
                List<clsPayment> mPaymentList = new List<clsPayment>();
                Int32 Index = 0;
                while(Index< dBConnection.Count)
                {
                    clsPayment NewPayment = new clsPayment();
                    //get payment query results
                    NewPayment.PaymentId = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["PaymentId"]);
                    NewPayment.PayeeName = Convert.ToString(dBConnection.DataTable.Rows[Index]["PayeeName"]);
                    NewPayment.Method = Convert.ToString(dBConnection.DataTable.Rows[Index]["Method"]);
                    NewPayment.CardNumber = Convert.ToString(dBConnection.DataTable.Rows[Index]["CardNumber"]);
                    NewPayment.Amount = Convert.ToDecimal(dBConnection.DataTable.Rows[Index]["Amount"]);
                    NewPayment.PaymentDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["PaymentDate"]);

                    Index++;
                    mPaymentList.Add(NewPayment);
                }

                //return the list of Payments
                return mPaymentList;

            }
            set { mPaymentList = value; }
        }

        //public property for Count

        public int Count
        {
            get { return dBConnection.Count; }
            set { /*Think about this later*/}
        }

        public clsPayment ThisPayment
        {
            get { //return to the private data
                return mThisPayment;
            }
            set { //set this private data
                mThisPayment=value;
            }
        }

        public int Add()
        {
            dBConnection = new clsDataConnection();
            //add a new record to the database based on the values of ThisPayment
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            dBConnection.AddParameter("@PayeeName", mThisPayment.PayeeName);
            dBConnection.AddParameter("@Method", mThisPayment.Method);
            dBConnection.AddParameter("@CardNumber", mThisPayment.CardNumber);
            dBConnection.AddParameter("@Amount", mThisPayment.Amount);
            dBConnection.AddParameter("@PaymentDate",mThisPayment.PaymentDate);
            //execute the query returning the primary key value
            return dBConnection.Execute("sproc_tblPayment_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisAddress();
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            dBConnection = new clsDataConnection();
            //set the parameters for the stored procedure
            dBConnection.AddParameter("@PaymentId", mThisPayment.PaymentId);
            //execute the stored procedure
            dBConnection.Execute("sproc_tblPayment_Delete");
        }

        public void Update()
        {
            dBConnection = new clsDataConnection();
            //update an existing record based on the values of thisInventory
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            dBConnection.AddParameter("@PaymentId", mThisPayment.PaymentId);
            dBConnection.AddParameter("@PayeeName", mThisPayment.PayeeName);
            dBConnection.AddParameter("@Method", mThisPayment.Method);
            dBConnection.AddParameter("@CardNumber", mThisPayment.CardNumber);
            dBConnection.AddParameter("@Amount", mThisPayment.Amount);
            dBConnection.AddParameter("@PaymentDate", mThisPayment.PaymentDate);

            //execute the stored procedure
            dBConnection.Execute("sproc_tblPayment_Update");
        }
        public void ReportByMethod(string Method)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            //clsDataConnection DB = new clsDataConnection();
            //send the category parameter to the database
            dBConnection = new clsDataConnection();
            dBConnection.AddParameter("@Method", Method);
            //execute the stored procedure
            dBConnection.Execute("sproc_tblPayment_FilterByMethod");
            //populate the array list with the data table
            PopulateArray(dBConnection);
        }

        void PopulateArray(clsDataConnection dBConnection)
        {
            //Poplates the array list based on the data table in the parameter
            //var for the index
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = dBConnection.Count;
            mPaymentList = new List<clsPayment>();
            while(Index<RecordCount)
            {
                //create a blank payment
                clsPayment AnPayment = new clsPayment();
                //read in the fields from current record
                AnPayment.PaymentId = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["PaymentId"]);
                AnPayment.PayeeName = Convert.ToString(dBConnection.DataTable.Rows[Index]["PayeeName"]);
                AnPayment.Method = Convert.ToString(dBConnection.DataTable.Rows[Index]["Method"]);
                AnPayment.CardNumber = Convert.ToString(dBConnection.DataTable.Rows[Index]["CardNumber"]);
                AnPayment.Amount = Convert.ToDecimal(dBConnection.DataTable.Rows[Index]["Amount"]);
                AnPayment.PaymentDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["PaymentDate"]);
                //add the recordto teh private data member
                mPaymentList.Add(AnPayment);
                Index++;
            }
        }
    }

   
}