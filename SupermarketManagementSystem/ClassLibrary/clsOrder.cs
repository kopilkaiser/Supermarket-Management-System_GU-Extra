using System;

namespace ClassLibrary
{
    public class clsOrder
    {


        private int mOrderId;
        private string mEmail;
        private int mPaymentId;
        private DateTime mPurchasedDate;

        public int OrderId
        {
            get
            {
                return mOrderId;
            }

            set
            {
                mOrderId = value;
            }
        }




        public String Email
        {
            get
            {
                return mEmail;
            }

            set
            {
                mEmail = value;
            }
        }

        public int PaymentId
        {
            get
            {
                return mPaymentId;
            }

            set
            {
                mPaymentId = value;
            }
        }
        public DateTime PurchasedDate
        {
            get
            {
                return mPurchasedDate;
            }

            set
            {
                mPurchasedDate = value;
            }
        }

       

        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Inventory id to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database from the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPaymentId = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentId"]);
                mPurchasedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PurchasedDate"]);
                //mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(string email, string paymentId, string purchasedDate)
        {
            // create a variable to store any error message
            string Error = "";
            Int32 PaymentIdTemp;
            DateTime DateTemp;

            //if Email entered is valid 
            if (email.Length == 0)
            {
                Error = Error + "The Email cannot be blank : ";
            }

            if (email.Length > 50)
            {
                Error = Error + "The Email cannot exceed 100 characters : ";
            }

            //if paymentId entered is valid 
            try
            {
                PaymentIdTemp = Convert.ToInt32(paymentId);

                if (PaymentIdTemp > 10000)
                {
                    Error = Error + "Payment Id cannot exceed the limit of  10000 : ";
                }

                if (PaymentIdTemp <= 0)
                {
                    Error = Error + "Payment Id can not be less than or equal to zero : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "Invalid payment Id : ";
            }

            //if purchasedDate entered is valid 
            try
            {
                // convert the string value to DateTime
                //& then copy the value of dateAdded to DateTemp variable
                DateTemp = Convert.ToDateTime(purchasedDate);
                //if date value is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "Date cannot be in the past : ";
                }
                //if date value is more than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "Date cannot be in the future : ";
                }
            }
            //if date entered is an invalid date
            catch
            {
                //record the error
                Error = Error + "The date entered was not a valid date : ";
            }

            return Error;
        }

        public string AllDetails
        {
            get
            {
                return "OrderId:" + OrderId + "_" + "Email:" + Email + "_" + "PurchasedDate:" + PurchasedDate + "_" + "PaymentId:" + PaymentId; 
            }
        }

    }
}
