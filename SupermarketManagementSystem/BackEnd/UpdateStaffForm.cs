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
            
            DisplayStaffs();
            txtDateJoined.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        public void DisplayStaffs()
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

        public void Update()
        {

            //create an instance of the Staff Collenction
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //validate the data on the web form
            string Error = AllStaffs.ThisStaff.Valid(txtAccountNo.Text, txtName.Text, txtPhonenum.Text, txtDateJoined.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {

                //find the record to update
                AllStaffs.ThisStaff.Find(mStaffId);
                //get the data entered by the user
                AllStaffs.ThisStaff.Name = txtName.Text;
                AllStaffs.ThisStaff.AccountNo = Convert.ToInt32(txtAccountNo.Text);
                AllStaffs.ThisStaff.Phonenum = Convert.ToString(txtPhonenum.Text);
                AllStaffs.ThisStaff.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
                AllStaffs.ThisStaff.Active = chkActive.Checked;
                //add the record
                AllStaffs.Update();
                //all done so redirect back to the main page
                StaffManageForm IM = new StaffManageForm();
                this.Hide();
                IM.Show();
                this.Close();
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered : " + Error;
            }
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
