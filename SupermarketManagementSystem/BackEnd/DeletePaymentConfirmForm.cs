using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace BackEnd
{
    public partial class DeletePaymentConfirmForm : Form
    {
        private int mPaymentId = 0;
        public int PaymentId
        {
            set
            {
                mPaymentId = value;
            }
        }


        public DeletePaymentConfirmForm()
        {
            InitializeComponent();
        }

        void DeletePayment()
        {
            //function to delete the selected record

            //create an instance of the Inventory List
            clsPaymentCollection AllPayment = new clsPaymentCollection();
            //find the record to delete
            AllPayment.ThisPayment.Find(mPaymentId);
            //delete the record
            AllPayment.Delete();
        }


        private void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeletePayment();
            //redirect to the main Form
            PaymentManageForm paymentManageForm = new PaymentManageForm();
            this.Show();
            paymentManageForm.Show();
            this.Close();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //redirect to the main form
            PaymentManageForm paymentManageForm= new PaymentManageForm();
            this.Show();
            paymentManageForm.Show();
            this.Close();
        }

       
    }
}
