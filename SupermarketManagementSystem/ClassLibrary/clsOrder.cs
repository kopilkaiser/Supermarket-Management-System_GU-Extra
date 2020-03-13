using System;

namespace ClassLibrary
{
    public class clsOrder
    {


        private int mOrderId
        private int mAccountNo;
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




        public int AccountNo
        {
            get
            {
                return mAccountNo;
            }

            set
            {
                mAccountNo = value;
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


     /* public bool Active
        {
            get
            {
                return mActive;
            }

            set
            {
                mActive = value;
            }
        }
        */

       

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
                mAccountId = Convert.ToInt32(DB.DataTable.Rows[0]["AccountId"]);
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

        public string Valid(string accountNo, string paymentId, string purchasedDate)
        {
            // create a variable to store any error message
            String Error = "";

            Int32 OrderIdTemp;
            Int32 AccountNoTemp;
            Int32 PaymentIdTemp;
            DateTime DateTemp;
            //if price entered is a valid price
            /*try
            {
                PriceTemp = Convert.ToDecimal(price);

                if (PriceTemp > 20000m)
                {
                    Error = Error + "The price of the full ordrer cannot exceed 20000 : ";
                }

                if (PriceTemp < 0.20m)
                {
                    Error = Error + "The price of Order  cannot be less than 0.20 pence : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The price entered is not valid : ";
            }

            //if Quantity entered is a valid quantity
            try
            {
                QuantityTemp = Convert.ToInt32(quantity);

                if (QuantityTemp > 100)
                {
                    Error = Error + "The quantity of Order cannot exceed 100 : ";
                }

                if (QuantityTemp <= 0)
                {
                    Error = Error + "The full order quantity cannot be less than or qual to zero : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The Order is not valid : ";
            }
            */

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
                Error = Error + "Invalid date : ";
            }

            return Error;
        }

    }
}
