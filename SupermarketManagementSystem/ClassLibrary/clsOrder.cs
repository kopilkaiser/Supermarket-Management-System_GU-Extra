﻿using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int mOrderId;
        private int mInventoryId;
        private int mQuantity;
        private decimal mPrice;
        private DateTime mPurchasedDate;
        private bool mActive;
        private string mOrderCode;

        public string OrderCode
        {
            get
            {
                return mOrderCode;
            }

            set
            {
                mOrderCode = value;
            }
        }
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

        public int InventoryId
        {
            get
            {
                return mInventoryId;
            }

            set
            {
                mInventoryId = value;
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

        

        public int Quantity
        {
            get
            {
                return mQuantity;
            }

            set
            {
                mQuantity = value;
            }
        }

      

        public decimal Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }
        public bool Active
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


        /* public int Quantity { get; set; }
         public decimal Price { get; set; }
         public int OrderId { get; set; }
         public int InventoryId { get; set; }
         public DateTime PurchasedDate { get; set; }
         public bool Active { get; set; }
         public string Error { get; private set; }*/


       

        public string Valid(string quantity, string price, string purchasedDate, string inventoryId)
        {
            // create a variable to store any error message 
            String Error = "";
            DateTime DateTemp;
            decimal PriceTemp;
            Int32 QuantityTemp;
            Int32 InventoryIdTemp;
            //if price entered is a valid price
            try
            {

                PriceTemp = Convert.ToDecimal(price);

                if (PriceTemp > 10000m)
                {
                    Error = Error + "The price of the full ordrer cannot exceed 10000 : ";
                }

                if (PriceTemp < 0m)
                {
                    Error = Error + "The price of Order  cannot be less than or equsl to zero : ";
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

                if (QuantityTemp > 101)
                {
                    Error = Error + "The quantity of Order cannot exceed 100 : ";
                }

                if (QuantityTemp < 0)
                {
                    Error = Error + "Thefull order price can not be less than 0.20pence : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The Order is not valid : ";

            }
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
        public void Find(int primaryKey)
        {


        }

    }
}