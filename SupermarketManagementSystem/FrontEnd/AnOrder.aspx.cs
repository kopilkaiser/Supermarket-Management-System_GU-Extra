using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    void Add()
    {
        //create an instance of the Inventory Collenction
        clsOrderCollection  AllOrders = new clsOrderCollection();
        //validate the data on the web form
        string Error = AllOrders.ThisOrder.Valid(txtOrderId.Text, txtInventoryId.Text, txtQuantity.Text, txtPrice.Text, txtPurchasedDate.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            AllOrders.ThisOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
            AllOrders.ThisOrder.InventoryId = Convert.ToInt32(txtInventoryId.Text);
            AllOrders.ThisOrder.Quantity = Convert.ToInt32(txtQuantity.Text);
            AllOrders.ThisOrder.Price = Convert.ToDecimal(txtPrice.Text);
            AllOrders.ThisOrder.PurchasedDate = Convert.ToDateTime(txtPurchaseDate.Text);
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
        // add the new record
        Add();
        // all  done so redirect back to the main page 
        Response.Redirect("OrderManagementStaff");
    }
}