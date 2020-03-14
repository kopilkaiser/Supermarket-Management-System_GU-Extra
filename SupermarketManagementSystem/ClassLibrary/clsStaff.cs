using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private int mStaffId;
        private int mAccountNo;
        private string mName;
        private string mPhonenum;
        private DateTime mDateJoined;
        private bool mActive;



        public int StaffId
        {
            get
            {
                return mStaffId;
            }

            set
            {
                mStaffId = value;
            }
        }


        public int AccountNo
        {
            get
            {
                return mAccountNo;
            }

            set
            {
                mAccountNo = value;
            }
        }


        public string Name
        {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }
        }


        public string Phonenum
        {
            get
            {
                return mPhonenum;
            }

            set
            {
                mPhonenum = value;
            }
        }

        public DateTime DateJoined
        {
            get
            {
                return mDateJoined;
            }

            set
            {
                mDateJoined = value;
            }
        }

        public bool Active
        {
            get
            {
                return mActive;
            }

            set
            {
                mActive = value;
            }
        }

      
        public string Valid(string accountEmail, string accountPassword)
        {
            string Error = "";

            if (accountEmail.Length == 0)
            {
                Error = Error + "The Email cannot be blank : ";
            }

            if (accountEmail.Length > 80)
            {
                Error = Error + "The Email cannot exceed 100 characters : ";
            }

            if (accountPassword.Length == 0)
            {
                Error = Error + "The Password cannot be blank : ";
            }

            if (accountPassword.Length > 80)
            {
                Error = Error + "The Password cannot exceed 100 characters : ";
            }

            return Error;
        }

        public bool Find(int StaffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the AccountNo to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database from the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mAccountNo = Convert.ToInt32(DB.DataTable.Rows[0]["AccountNo"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPhonenum = Convert.ToString(DB.DataTable.Rows[0]["Phonenum"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]); ;

                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string AllDetails
        {
            get
            {
                return ("StaffId:" + StaffId + "_" + "AccountNo:" + AccountNo + "_" + "Name:" + Name + "_" + "Phonenum:" + Phonenum + "_" + "DateJoined:" + DateJoined) ;
            }
        }
    }
}