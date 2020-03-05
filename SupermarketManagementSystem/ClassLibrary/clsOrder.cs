using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public int InventoryId { get; set; }
        public DateTime PurchasedDate { get; set; }
        public bool Active { get; set; }
        public string Error { get; private set; }

        
        public void Find(int primaryKey)
        {


        }

        public string Valid(string quantity, string price, string purchasedDate, string inventoryId)
        {
            // create a variable to store any error message 
            String Error = "";
            DateTime DateTemp;

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