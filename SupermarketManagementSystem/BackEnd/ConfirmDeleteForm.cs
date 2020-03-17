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
    public partial class ConfirmDeleteForm : Form
    {
        private int mStaffId = 0;
        public int StaffID
        {
            set
            {
                mStaffId = value;
            }
        }

        public ConfirmDeleteForm()
        {
            InitializeComponent();
        }

        private void btnYES_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteStaff();
            //redirect to the main form
            StaffManageForm StaffManageForm = new StaffManageForm();
            this.Show();
            StaffManageForm.Show();
            this.Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            //redirect to the main form
            StaffManageForm StaffManageForm = new StaffManageForm();
            this.Show();
            StaffManageForm.Show();
            this.Close();
        }

        void DeleteStaff()
        {
            //function to delete the selected record

            //create an instance of the Staff List
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //find the record to delete
            AllStaffs.ThisStaff.Find(mStaffId);
            //delete the record
            AllStaffs.Delete();
        }
    }
}