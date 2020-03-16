using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using ClassLibrary;


namespace BackEnd
{
    public partial class AddPayment : Form
    {
        int PaymentId;
        clsPayment AnPayment = new clsPayment();
        public AddPayment()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Payment
            this.Hide();
            
            this.Close();
        }
    }
}
