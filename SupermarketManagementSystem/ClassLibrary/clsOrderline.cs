using System;

namespace ClassLibrary
{
    public class clsOrderline
    {
        private int mOrderlineId;
        private int mOrderId;
        private int mInventoryId;
        private int mQuantity;


        public int OrderlineId
        {
            get
            {
                return mOrderlineId;
            }

            set
            {
                mOrderlineId = value;
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

        public string Valid(string orderId, string inventoryId, string quantity)
        {
            // create a variable to store any error message
            String Error = "";


            Int32 QuantityTemp;

            Int32 InventoryIdTemp;
            //if price entered is a valid price


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

            try
            {
                InventoryIdTemp = Convert.ToInt32(inventoryId);

                if (InventoryIdTemp > 50000)
                {
                    Error = Error + "Invalid inventory Id : ";
                }

                if (InventoryIdTemp <= 0)
                {
                    Error = Error + "please enter an inventory Id : ";
                }





            }
            catch
            {
                //record the error
                Error = Error + "The Order is not valid : ";
            }




            return Error;
        }

        public bool Find(int OrderlineId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Inventory id to search for
            DB.AddParameter("@OrderlineId", OrderlineId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderline_FilterByOrderlineId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database from the private data members
                mOrderlineId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderlineId"]);
               
                
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
               
                mInventoryId = Convert.ToInt32(DB.DataTable.Rows[0]["InventoryId"]);
               
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

        public string AllDetails
        {
            get
            {
                return "OrderlineId:" + OrderlineId + "_" + "OrderId:" + OrderId + "_" + "Quantity:" + Quantity + "_" + "InventoryId:" + InventoryId;
            }
        }

    }
}









