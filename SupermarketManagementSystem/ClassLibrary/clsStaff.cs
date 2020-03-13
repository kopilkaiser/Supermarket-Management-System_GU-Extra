using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private string mAccountEmail;
        private string mAccountPassword;
        private bool mActive;
        private bool mIsAdmin;
        private int mAccountNo;


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

        public bool IsAdmin
        {
            get
            {
                return mIsAdmin;
            }

            set
            {
                mIsAdmin = value;
            }
        }

        public string AccountEmail
        {
            get
            {
                return mAccountEmail;
            }

            set
            {
                mAccountEmail = value;
            }
        }

        public string AccountPassword
        {
            get
            {
                return mAccountPassword;
            }

            set
            {
                mAccountPassword = value;
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

        public bool Find(int accountNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the AccountNo to search for
            DB.AddParameter("@AccountNo", AccountNo);
            //execute the stored procedure
            DB.Execute("sproc_tblAccount_FilterByAccountNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database from the private data members
                mAccountNo = Convert.ToInt32(DB.DataTable.Rows[0]["AccountNo"]);
                mAccountEmail = Convert.ToString(DB.DataTable.Rows[0]["AccountEmail"]);
                mAccountPassword = Convert.ToString(DB.DataTable.Rows[0]["AccountPassword"]);
                mIsAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAdmin"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
               
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
                return "AccountEmail:" + AccountEmail + "AccountPassword:" + AccountPassword;
            }
        }
    }
}