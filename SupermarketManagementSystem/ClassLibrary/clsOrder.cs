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

        public string Valid(int quantity, decimal price)
        {
            // create a variable to store any error message 
            String Error = "";
            //if the seleted quantity for the order less than 0 or equal to zero
            if (quantity <= 0)
            {
                // store this error message 
                Error = Error + "The quantity cannot be less than one";
            }
            // if the selected quantity exceeds 100
            if (quantity > 100)
            {
                // store this error message 
                Error = Error + "The selected quantity cannot exceed 100";

            }
            // if the oder price is less than 0.20 
            if (price <= 0.20m)
            {
                Error = Error + " The price for the order cannot be less than 0.20 ";
            }
            // if the order price exceeds 10,000
            if (price > 10000)
            {
                Error = Error + "the price for the order exceeds the limit ";
            }
            // return the error message 
            return Error;
        }

        public void Find(int primaryKey)
        {
            
        }

        public string Valid(decimal price, int quantity, string purchasedDate)
        {
            DateTime DateTemp;
            try
            {

                // convert the string value to DateTime
                //& then copy the value of dateAdded to DateTemp variable
                DateTemp = Convert.ToDateTime(PurchasedDate);
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