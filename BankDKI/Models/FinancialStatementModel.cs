using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankDKI.Models
{
    public class FinancialStatementModel
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public DateTime YearAuditedProjected { get; set; }
        public decimal Amount { get; set; }
    }
}