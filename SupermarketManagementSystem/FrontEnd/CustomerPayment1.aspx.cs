using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerPayment1 : System.Web.UI.Page
{
    Int32 InventoryId;
    decimal TotalPrice;
    clsSecurity Sec;
    clsCart MyCart = new clsCart();
    clsPaymentCollection AllPayments = new clsPaymentCollection();
    clsCartItem MyCartList = new clsCartItem();
    protected void Page_Load(object sender, EventArgs e)
    {
        MyCart = (clsCart)Session["MyCart"];
        MyCartList = (clsCartItem)Session["MyCartList"];
        Sec = (clsSecurity)Session["Sec"];

        MyCart.Email = Sec.UserEMail;
        txtPaymentDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

        InventoryId = Convert.ToInt32(Request.QueryString["InventoryId"]);
        TotalPrice = Convert.ToDecimal(Request.QueryString["TotalPrice"]);
        //clsCartItem AnItem = new clsCartItem();
        //txtMyPrice.Text = Convert.ToString(MyCartList.TotalPrice);
    }


    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //you must also save the cart every time the unload event takes place
        Session["MyCart"] = MyCart;
        //update the security state in the session
        Session["Sec"] = Sec;
    }

    protected void btnCheckOut_Click(object sender, EventArgs e)
    {

        string Error = AllPayments.ThisPayment.Valid(txtPayeeName.Text, txtCardNumber.Text, Convert.ToString(DDListMethod.SelectedItem), txtAmount.Text, txtPaymentDate.Text);
        if (Error == "")
        {

            //save the card no
            Add();
            MyCart.CardNumber = txtCardNumber.Text;
            MyCart.Checkout();

            Response.Redirect("Thanks.aspx");
        }

        else
        {
            lblError.Text = "There were problems with the data entered : " + Error;
        }
    }

    void Add()
    {
        //create an instance of the Payment Collenction
        clsPaymentCollection AllPayments = new clsPaymentCollection();
        //validate the data on the web form
        string Error = AllPayments.ThisPayment.Valid(txtPayeeName.Text, txtCardNumber.Text, Convert.ToString(DDListMethod.SelectedItem), txtAmount.Text, txtPaymentDate.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            AllPayments.ThisPayment.PayeeName = txtPayeeName.Text;
            AllPayments.ThisPayment.CardNumber = txtCardNumber.Text;
            AllPayments.ThisPayment.Method = Convert.ToString(DDListMethod.SelectedItem);
            AllPayments.ThisPayment.Amount = Convert.ToDecimal(txtAmount.Text);
            AllPayments.ThisPayment.PaymentDate = Convert.ToDateTime(txtPaymentDate.Text);


            //add the record
            AllPayments.Add();

        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered : " + Error;
        }
    }
}