using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankDKI.Models
{
    public class CreditRatingHistoryModel
    {
        public decimal Id { get; set; }
        public decimal UserId { get; set; }
        public string Description { get; set; }
        public string PaymentHistory { get; set; }
        public string AmountDebit { get; set; }
        public string LengthCrditHistory { get; set; }
        public string Comments { get; set; }
    }
}