using System;

namespace ClassLibrary
{
    public class clsInventory
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public string DateAdded { get; set; }

        public string Valid(string name, decimal price, int quantity, string category, string dateAdded)
        {
            string Error = "";
            DateTime DateTemp;

            if (name.Length == 0)
            {
                Error = Error + "The inventory name cannot be blank";
            }

            if (name.Length > 80)
            {
                Error = Error + "The inventory name cannot exceed 100 characters";
            }

            if(price>100000m)
            {
                Error = Error + "The price of inventory cannot exceed 100000";
            }

            if(price<0m)
            {
                Error = Error + "The price of inventory cannot be less than zero";
            }

            if (quantity > 1000)
            {
                Error = Error + "The quantity of inventory cannot exceed 1000";
            }

            if (quantity < 0)
            {
                Error = Error + "The quantity of inventory cannot be less than zero";
            }

            if (category.Length == 0)
            {
                Error = Error + "The name for inventory category cannot be blank";
            }

            if (category.Length > 100)
            {
                Error = Error + "The name for inventory category cannot exceed 100 characters";
            }

            //if date entered is a valid date
            try
            {
                // convert the string value to DateTime
                //& then copy the value of dateAdded to DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
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
    }
}