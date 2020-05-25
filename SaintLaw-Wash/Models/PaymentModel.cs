using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace SaintLaw_Wash.Models
{
    public class PaymentModel
    {
        public int InvoiceID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string PaymentType { get; set; }
        public int AdvancePayment { get; set; }
        public int RecievePayment { get; set; }
        public int Balance { get; set; }
    }
}
