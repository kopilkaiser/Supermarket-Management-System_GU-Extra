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
    public partial class UpdateStaffForm : Form
    {
        private int mStaffId = 0;
        public int StaffID
        {
            set
            {
                mStaffId = value;
            }
        }

        public static int tempStaff { get; set; }

        public UpdateStaffForm()
        {
            InitializeComponent();
        }

        private void UpdateStaffForm_Load(object sender, EventArgs e)
        {
            DisplayStaff();
        }

        public void DisplayStaff()
        {
            //create an instance of the staff collection
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //find the record to update
            AllStaffs.ThisStaff.Find(mStaffId);
            //display the data for this record
            txtAccountNo.Text = AllStaffs.ThisStaff.AccountNo.ToString();
            txtName.Text = AllStaffs.ThisStaff.Name;
            txtPhonenum.Text = AllStaffs.ThisStaff.Phonenum.ToString();
            txtDateJoined.Text = AllStaffs.ThisStaff.DateJoined.ToString();
            chkActive.Checked = AllStaffs.ThisStaff.Active;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StaffManageForm IM = new StaffManageForm();

            this.Hide();
            IM.Show();
            this.Close();
        }
    }
}
