using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        private bool Success;

        public string Method { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string CardNumber { get; set; }


        public string Valid(string name, string category, string cardnumber, string method, string amount, string paymentDate)
        {
            return "";

            DateTime DateTemp;
            decimal AmountTemp;
            Int64 CardNumberTemp;
            string Error = "";
            if (name.Length == 0)
            {
                Error = Error + "Name field should not be blank: ";
            }

            if (name.Length > 81)
            {
                Error = Error + "Name field should not be excessed 100 characters : ";
            }

            //if amount entered is amount shows
            try
            {
                AmountTemp = Convert.ToDecimal(amount);
                
                if (AmountTemp > 10000000m)
                {
                    Error = Error + "The amount cannot be excessed 10000000: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The amount is not suficiant : ";
            }

            //if method entered is a valid 

        }
    }
}