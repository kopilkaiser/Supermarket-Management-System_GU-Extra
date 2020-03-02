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
            if (quantity >100)
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
    }
}