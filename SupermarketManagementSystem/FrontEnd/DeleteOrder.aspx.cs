using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteOrder : System.Web.UI.Page
{
    // var to store the primary key value of the record to be deleted 
    Int32 OrderId;
    //event handler for the load event 
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the address to be deleted from the sesssion object 
        OrderId = Convert.ToInt32(Session["OrderId"]);

    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderManagementStaff.aspx");
    }

    void DeleteORDER()
    {
        //function to delete the selected record

        //create a instance of the Order List
        clsOrderCollection AllOrders = new clsOrderCollection();
        //find the record to delete
        AllOrders.ThisOrder.Find(OrderId);
        //delete the record
        AllOrders.Delete();
    }


    protected void btnYes_Click1(object sender, EventArgs e)
    {
        //delete the record
        DeleteORDER();
        //redirect back to the main page
        Response.Redirect("OrderManagementStaff.aspx");

    }
}