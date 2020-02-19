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

            if (name.Length > 100)
            {
                Error = Error + "The inventory name cannot exceed 100 characters";
            }

            if(price>100000m)
            {
                Error = Error + "The price of inventory cannot exceed 100000";
            }

            if(price<100000m)
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

            return Error;
        }
    }
}