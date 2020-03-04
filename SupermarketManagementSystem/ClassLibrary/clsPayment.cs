using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        
        public string Method { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public string Valid(string method, string amount, string paymentDate)
        {
            return "";
        }

    }
}