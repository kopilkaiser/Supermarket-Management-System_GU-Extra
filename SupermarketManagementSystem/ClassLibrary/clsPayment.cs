using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public string PayeeName { get; set; }
        public Int64 CardNumber { get; set; }
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }



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

                if (CardNumberTemp < 9999999999999)
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
            //if date entered is an indivalid date
            catch
            {
                //record the error
                {
                    Error = Error + "The date entered was not a valid date :";
                }
            }

            return Error;
        }
        public bool Find (int PaymentId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Payment Id to search for 
            DB.AddParameter("@PaymentId", PaymentId);
            //execute the stored procedure
            DB.Execute("sproc_tblPayment_FilterByPAymentId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database from the private data members
                PaymentId = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentId"]);
                OrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                PayeeName = Convert.ToString(DB.DataTable.Rows[0]["PayeeName"]);
                return true;

            }
            else
            {
                return false;
            }
        }
        

    }
}
