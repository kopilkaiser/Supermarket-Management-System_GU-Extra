﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class InventoryDetails : System.Web.UI.Page
{
    clsCart MyCart = new clsCart();
    Int32 InventoryId;
    string Name;
    decimal Price;
    protected void Page_Load(object sender, EventArgs e)
    {
        //upon loading the page you need to read in the cart from the session object
        MyCart = (clsCart)Session["MyCart"];
        //you also need to get the product id from the query string
        InventoryId = Convert.ToInt32(Request.QueryString["InventoryId"]);
        Name = Convert.ToString(Request.QueryString["Name"]);
        Price = Convert.ToDecimal(Request.QueryString["Price"]);

        txtName.Text = Convert.ToString(Name);
        
        txtPrice.Text = Convert.ToString(Price);
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //you must also save the cart every time the unload event takes place
        Session["MyCart"] = MyCart;
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCartItem
        clsCartItem AnItem = new clsCartItem();
        //set the product id
        AnItem.InventoryId = InventoryId;
        //set the quantity
        AnItem.QTY = Convert.ToInt32(txtQuantity.Text);
        AnItem.Price = Convert.ToInt32(txtPrice.Text);
        //add the item to the cart's products collection
        MyCart.Products.Add(AnItem);
        //go back to shopping
        Response.Redirect("tempInventory.aspx");
    }
}