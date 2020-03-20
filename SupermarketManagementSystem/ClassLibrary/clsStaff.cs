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

      
        public string Valid(string accountno, string name, string phonenum, string datejoined)
        {
            string Error = "";

            DateTime DateTemp;
            Int32 AccountNoTemp;

            //if accountNo entered is valid 
            try
            {
                AccountNoTemp = Convert.ToInt32(accountno);

                if (AccountNoTemp > 10000)
                {
                    Error = Error + "Account No can not be exceed the limit of 10 : ";
                }

                if (AccountNoTemp <= 0)
                {
                    Error = Error + "Please enter an Account No: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The AccountNo is not valid: ";
            }

            if (name.Length == 0)
            {
                Error = Error + "The name cannot be blank : ";
            }

            if (name.Length > 50)
            {
                Error = Error + "The name cannot exceed 100 characters : ";
            }

            if (phonenum.Length < 10)
            {
                Error = Error + "The Phonenum cannot be less than 10 : ";
            }

            if (phonenum.Length > 15)
            {
                Error = Error + "The Phonenum cannot exceed 15 numbers : ";
            }

            //if date entered is a valid date
            try
            {
                // convert the string value to DateTime
                //& then copy the value of datejoined to DateTemp variable
                DateTemp = Convert.ToDateTime(datejoined);
                //if date value is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "Date cannot be in the past : ";
                }
                //if date value is more than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "Date cannot be in the future : ";
                }
            }
            //if date entered is an invalid date
            catch
            {
                //record the error
                Error = Error + "The date entered is not a valid date : ";
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
                return ("StaffId:" + StaffId + "_" + "AccountNo:" + AccountNo + "_" + "Name:" + Name + "_" + "Phonenum:" + Phonenum + "_" + "DateJoined:" + DateJoined.ToString("dd/MM/yyyy")) ;
            }
        }
    }
}