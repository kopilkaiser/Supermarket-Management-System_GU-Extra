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
using ListBox = System.Windows.Forms.ListBox;

namespace BackEnd
{
    public partial class StaffManageForm : Form
    {

        Int32 StaffId;
        clsDataConnection dBConnection;
        public StaffManageForm()
        {
            InitializeComponent();
        }

        private void StaffManageForm_Load(object sender, EventArgs e)
        {
            //update the list box with Inventory database list
            lblError.Text = DisplayStaffs("") + " records in the database";

            // Clear all selections in the ListBox.
            lstStaff.ClearSelected();
        }

        Int32 DisplayStaffs(string CategoryFilter)
        {
            //create an instance of the Inventory collection
            clsStaffCollection AllStaffs = new clsStaffCollection();
            AllStaffs.ReportByName(CategoryFilter);
            //set the data source to the list of inventories in the collection
            lstStaff.DataSource = AllStaffs.StaffList;
            //set the name of the primary Key
            lstStaff.ValueMember = "StaffId";
            //set the data field to display

            lstStaff.DisplayMember = "AllDetails";

            AllStaffs.ReportByName(CategoryFilter);

            return AllStaffs.Count;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsStaff AnStaff = new clsStaff();
            AnStaff.StaffId = -1;
            AddStaffForm ZX = new AddStaffForm();
            this.Hide();
            ZX.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 StaffId;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                StaffId = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                UpdateStaffForm.tempStaff = StaffId;

                //redirect to the delete page
                UpdateStaffForm UpdateStaff = new UpdateStaffForm();
                UpdateStaff.StaffID = StaffId;
                this.Hide();
                UpdateStaff.ShowDialog();
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 StaffId;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                StaffId = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                UpdateStaffForm.tempStaff = StaffId;

                //redirect to the delete page
                ConfirmDeleteForm ConfirmDelete = new ConfirmDeleteForm();
                ConfirmDelete.StaffID = StaffId;
                this.Hide();
                ConfirmDelete.ShowDialog();
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayAddress function to the record count var
            RecordCount = DisplayStaffs(txtCategory.Text);
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //declare var to storee the record count
            Int32 RecordCount;
            //assign the results of the DisplayAddress function to the record count var
            RecordCount = DisplayStaffs("");
            //display the number oof records fount
            lblError.Text = RecordCount + " records found";
            //clear the Category filter text box
            txtCategory.Text = "";

            lstStaff.ClearSelected();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            mdiBackEndMenuForm IM = new mdiBackEndMenuForm();

            this.Close();
            IM.ShowDialog();
            this.Close();
        }
    }
}
