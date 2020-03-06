using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class OrderManagementStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            lblError.Text = DisplayOrders("") + " records in the database";
        }

        //string temp;
        //temp = Guid.NewGuid().ToString();
        //TextBox1.Text = temp;


         /*Random random = new Random();
         int length = 8;
         for (int i = 0; i < length; i++)
         {
             if (random.Next(0, 3) == 0) //if random.Next() == 0 then we generate a random character
             {
                 TextBox1.Text += ((char)random.Next(65, 91)).ToString();
             }
             else //if random.Next() == 0 then we generate a random digit
             {
                 TextBox1.Text += random.Next(0, 9);
             }
         }*/
    }
    Int32 DisplayOrders(string OrderCodeFilter)
    {
        
        //create a new instance of the clsAddress
        clsOrderCollection AllOrders = new clsOrderCollection();
        //var to store the count of records
        Int32 RecordCount;
        //var to store the house no
        string InventoryId;
        //var to store the street name
        string Price;
        //var to store the post code
        string Quantity;
        //var to store the primary key value
        string PurchasedDate;

        string OrderId;
        string OrderCode;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstOrders.Items.Clear();
        //call the filter by post code method

        AllOrders.ReportByOrderCode(OrderCodeFilter);

        //get the count of records found
        RecordCount = AllOrders.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            //get the house no from the query results
            OrderId = Convert.ToString(AllOrders.OrderList[Index].OrderId);
            InventoryId = Convert.ToString(AllOrders.OrderList[Index].InventoryId);
            //get the street from the query results
            Price = Convert.ToString(AllOrders.OrderList[Index].Price);
            //get the post code from the query results
            Quantity = Convert.ToString(AllOrders.OrderList[Index].Quantity);
            //get the address no from the query results
            PurchasedDate = Convert.ToString(AllOrders.OrderList[Index].PurchasedDate);

            OrderCode = Convert.ToString(AllOrders.OrderList[Index].OrderCode);


            //set up a new object of class list item 
            ListItem NewItem = new ListItem("OrderId:" + OrderId + "_" + "OrderCode:" + "("+OrderCode+")" + "_" + "InventoryId:" + InventoryId + "_" + "Price:" + Price + "_" + "Quantity:" + Quantity + "_" + "PurchasedDate: " + PurchasedDate, OrderId);
            //add the new item to the list
            lstOrders.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this 
        Session["OrderId"] = -1;
        // redirect to the data entry page 
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrders.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderId = Convert.ToInt32(lstOrders.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the delete page
            Response.Redirect("DeleteOrder.aspx");
        }
        else 
        //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrders.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderId = Convert.ToInt32(lstOrders.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the delete page
            Response.Redirect("AnOrder.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDisplayall_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayOrder function to the record count var
        RecordCount = DisplayOrders("");
        //display the number of records found
        lblError.Text = RecordCount + " records in the database";
        //clear the post code filter text box
        txtboxOrderId.Text = "";
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayOrders function to the record count var
        RecordCount = DisplayOrders(txtboxOrderId.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }
}

