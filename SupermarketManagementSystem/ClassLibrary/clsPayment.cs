using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        
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
        }

    }
}