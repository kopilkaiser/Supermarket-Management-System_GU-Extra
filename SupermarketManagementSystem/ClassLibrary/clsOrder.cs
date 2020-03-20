using System;

namespace ClassLibrary
{
    public class clsOrder
    {


        private int mOrderId;
        private string mEmail;
        private string mCardNumber;
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
        public string CardNumber
        {
            get
            {
                return mCardNumber;
            }

            set
            {
                mCardNumber = value;
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
            //add the parameter for the Order id to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database from the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mCardNumber = Convert.ToString(DB.DataTable.Rows[0]["CardNumber"]);
                mPurchasedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PurchasedDate"]);
                
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

        public string Valid(string email, string cardNumber, string purchasedDate)
        {
            // create a variable to store any error message
            string Error = "";

            string EmailTemp;
            
            DateTime DateTemp;

            int OrderIdTemp;

            //if Email entered is valid 
            if (email.Length == 0)
            {
                Error = Error + "The Email cannot be blank : ";
            }

            if (email.Length > 50)
            {
                Error = Error + "The Email cannot exceed 50 characters : ";
            }
            if (email.Length < 5)
            {
                Error = Error + "The Email cannot be less than 5 character : ";
            }


            if (cardNumber.Length < 13)
            {
                Error = Error + "Card number is required to have 13 numbers : ";
            }

            if (cardNumber.Length > 16)
            {
                Error = Error + "Card Number cannot exceed 16 numbers : ";
            }

            //if purchasedDate entered is valid 
            try
            {
                // convert the string value to DateTime
                //& then copy the value of purchasedDate to PurchasedDateTemp variable
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
            // return the error message 
            return Error;
        }

        public string AllDetails
        {
            get
            {
                return "OrderId:" + OrderId + "_" + "Email:" + Email + "_" + "PurchasedDate:" + PurchasedDate.ToString("dd/MM/yyyy") + "_" + "CardNumber:" + CardNumber ; 
            }
        }

        public void ProcessCart(clsCart ShoppingCart)
        {
            ///at this point all the data has been captured by the presentation layer
            ///this is the stage where all of the data is passed to the data layer via the two stored procedures like so
            ///

            //first we add the order to the database using data from the cart's private data member s
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //pass the data as parameters to the data layer
            DB.AddParameter("@PurchasedDate", DateTime.Now.Date);
            DB.AddParameter("@Email", ShoppingCart.Email);
            DB.AddParameter("@CardNumber", ShoppingCart.CardNumber);

            //execute the stored procedure capturing the primary key of the new record in the variable OrderNo
            Int32 NewOrderNo;
            NewOrderNo = DB.Execute("sproc_tblOrder_Insert");

            //now we need to loop through all the products adding them to the order line table
            Int32 Index = 0;
            Int32 Count = ShoppingCart.Products.Count;
            while (Index < Count)
            {
                //reset the connection to the database
                DB = new clsDataConnection();
                DB.AddParameter("@OrderId", NewOrderNo);
                DB.AddParameter("@InventoryId", ShoppingCart.Products[Index].InventoryId);
                DB.AddParameter("@Quantity", ShoppingCart.Products[Index].QTY);
                Int32 OrderNo = DB.Execute("sproc_tblOrderLine_Insert");
                Index++;
            }
            //now look in the tables and the order should be present
            //we could also do other things here such as adjust stock levels
        }
    }
}
