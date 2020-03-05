﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class AnOrder : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //populate the list of Orders
            //if this is not a new record
            if (OrderId != -1)
            {
               
                DisplayOrder();
            }
            else
            {
                txtPurchasedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }

        }

    }

    private void DisplayOrder()
    {
        // create an instance of the Order collection 
        clsOrderCollection AllOrders = new clsOrderCollection();
        // find the record to update 
        AllOrders.ThisOrder.Find(OrderId);
        // display the data for the record 
        txtOrderId.Text = AllOrders.ThisOrder.OrderId.ToString();
        txtInventoryId.Text = AllOrders.ThisOrder.InventoryId.ToString();
        txtQuantity.Text = AllOrders.ThisOrder.Quantity.ToString();
        txtPrice.Text = AllOrders.ThisOrder.Price.ToString();
        txtPurchasedDate.Text = AllOrders.ThisOrder.PurchasedDate.ToString();
        ChkboxActive.Checked = AllOrders.ThisOrder.Active;

        
    }

    void Add()
    {
        //create an instance of the Inventory Collenction
        clsOrderCollection  AllOrders = new clsOrderCollection();
        //validate the data on the web form
        string Error = AllOrders.ThisOrder.Valid(txtQuantity.Text, txtPrice.Text, txtPurchasedDate.Text, txtInventoryId.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            //AllOrders.ThisOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
            AllOrders.ThisOrder.InventoryId = Convert.ToInt32(txtInventoryId.Text);
            AllOrders.ThisOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            AllOrders.ThisOrder.Price = Convert.ToDecimal(txtPrice.Text);
            AllOrders.ThisOrder.PurchasedDate = Convert.ToDateTime(txtPurchasedDate.Text);
            AllOrders.ThisOrder.Active = ChkboxActive.Checked;
            //add the record
            AllOrders.Add();
            //all done so redirect back to the main page
            Response.Redirect("OrderManagementStaff.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered : " + Error;
        }
    }

    protected void btnOK1_Click(object sender, EventArgs e)
    {
        if (OrderId == -1)
        {
            // add twhe new record
            Add();

        }
        else
        {
            // update the record 
            Update();

        }
        
        // all  done so redirect back to the main page 
        Response.Redirect("OrderManagementStaff.aspx");
    }

   void Update()
    {
       
    }
}