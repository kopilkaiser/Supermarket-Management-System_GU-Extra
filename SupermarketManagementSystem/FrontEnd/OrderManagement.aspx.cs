using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderManagement : System.Web.UI.Page
{
    // this function handles the load event for the page 
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            // update the list box 
            DisplayOrders();

        }
    }
    void DisplayOrders()
    {
        // create an instance of the county collection 
        ClassLibrary.clsOrderCollection Orders = new ClassLibrary.clsOrderCollection();
        // set the data source to the list of Order
        lstOrders.DataSource = Orders.OrderList;
        //set the name of the primary key 
        lstOrders.DataValueField = "OrderId";
        // set the data field to dispaly
        lstOrders.DataTextField = "InventoryId";
        //bind the data to the list 
        lstOrders.DataBind();
    }





}