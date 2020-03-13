using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCart
    {
        public clsCart()
        {

        }
        List<clsCartItem> mProducts = new List<clsCartItem>();
        public List<clsCartItem> Products
        {
            get
            {
               return mProducts;
            }
        }

    }

}
