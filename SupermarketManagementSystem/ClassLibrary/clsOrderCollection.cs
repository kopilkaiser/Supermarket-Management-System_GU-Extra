using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // private data member for the list 
        List<clsOrder> mOrderList = new List<clsOrder>();
        //public property for the Order list
        public List<clsOrder> OrderList
        {
            get
            {
                // return the private data 
                return mOrderList;


            }
            set
            {
                // set the private data 
                mOrderList = value;


            }

        }
        //public property for the count 
        public int Count
        {
            get
            {
                // return the count of the list 
                return mOrderList.Count;
            }
            set
            {

                // later on


            }
        }

       //public List<clsOrder> OrderList { get; set; }
        //public int Count { get; set; }
        public clsOrder ThisOrder { get; set; }
    }
   
}