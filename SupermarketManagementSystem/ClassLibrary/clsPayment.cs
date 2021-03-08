using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        private int mPaymentId;
        private string mPayeeName;
        private string mCardNumber;
        private string mMethod;
        private decimal mAmount;
        private DateTime mPaymentDate;

        public DateTime PaymentDate
        {
            get
            {
                return mPaymentDate;
            }

            set
            {
                mPaymentDate = value;
            }
        }

        public int PaymentId
        {
            get
            {
                return mPaymentId;
            }

            set
            {
                mPaymentId = value;
            }
        }

        public string PayeeName
        {
            get
            {
                return mPayeeName;
            }

            set
            {
                mPayeeName = value;
            }
        }

        public string CardNumber
        {
            get
            {
                return mCardNumber;
            }

            set
            {
                mCardNumber = value;
            }
        }

        public string Method
        {
            get
            {
                return mMethod;
            }

            set
            {
                mMethod = value;
            }
        }

        public decimal Amount
        {
            get
            {
                return mAmount;
            }

            set
            {
                mAmount = value;
            }
        }

        public string Valid(string payeeName, string cardNumber, string method, string amount, string paymentDate)        
        {

            string Error = "";

            decimal AmountTemp;
            Int64 CardNumberTemp;
            DateTime DateTemp;

            if (method.Length == 0)
            {
                Error = Error + "The method should not be blank : ";
            }
            if (method.Length > 20)
            {
                Error = Error + "The method cannot be other card, it should be DebitCard, MasterCard, CreaditCard : ";

            }

            if (payeeName.Length == 0)
            {
                Error = Error + "Card Holder Name field should not be blank : ";
            }

            if (payeeName.Length > 81)
            {
                Error = Error + "Card Holder Name field should not exceed 100 characters : ";
            }

            //if amount entered is a valid amount
            try
            {
                AmountTemp = Convert.ToDecimal(amount);

                if (AmountTemp > 10000000m)
                {
                    Error = Error + "The amount cannot be excessed 10000000 : ";
                }


                if (AmountTemp < 0m)
                {
                    Error = Error + "The amount cannot be negative : ";
                }
            }
            //if amount entered is not valid or sufficiant
            catch
            {
                //record the error
                Error = Error + "The amount entered is not valid : ";
            }

            //if CardNumber entered is a valid number
            try
            {
                CardNumberTemp = Convert.ToInt64(cardNumber);

                if (CardNumberTemp > 9999999999999999)
                {
                    Error = Error + "The card number cannot exceed 16 digits : ";
                }

                if (CardNumberTemp < 1111111111111)
                {
                    Error = Error + "The card number is required to have minimum 13 digits : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The card is not valid: ";
            }



            //Enter valid date
            try
            {
                //convert the string value to DateTime 
                //then copy the value of dateAdded to DateTemp variable
                DateTemp = Convert.ToDateTime(paymentDate);
                //if date value is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error message
                    Error = Error + "Date cannot be in the past: ";
                }
                //if date value is more than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "Date cannot be in the future: ";
                }
            }
            //if date entered is an invalid date
            catch
            {
                //record the error
                {
                    Error = Error + "The date entered was not a valid date :";
                }
            }

            return Error;
        }

        public bool Find(int PaymentId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Payment Id to search for 
            DB.AddParameter("@PaymentId", PaymentId);
            //execute the stored procedure
            DB.Execute("sproc_tblPayment_FilterByPaymentId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database from the private data members
                mPaymentId = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentId"]);
                mPayeeName = Convert.ToString(DB.DataTable.Rows[0]["PayeeName"]);
                mCardNumber = Convert.ToString(DB.DataTable.Rows[0]["CardNumber"]);
                mMethod = Convert.ToString(DB.DataTable.Rows[0]["Method"]);
                mAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Amount"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);

                return true;

            }
            else
            {
                return false;
            }
        }

        public string AllPayments
        {
            get
            {
                return ("PayeeName:" + PayeeName + "_" + "CardNumber:" + CardNumber + "_" + "Method:" + Method + "_" + "Amount:" + Amount + "_" + "PaymentDate:" + PaymentDate.ToString("dd/MM/yyyy"));
            }
        }


    }
}
