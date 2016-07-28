using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankDKI.Models
{
    public class FinancialStatementStandAloneModel
    {
        public List<FinancialStatementModel> CurrentAssets { get; set; }
        public List<FinancialStatementModel> FixedAssets { get; set; }
        public List<FinancialStatementModel> NonCurrentAssets { get; set; }
        public List<FinancialStatementModel> CurrentLiabilities { get; set; }
        public List<FinancialStatementModel> NonCurrentLiabilities { get; set; }
        public List<FinancialStatementModel> GrossProfit { get; set; }
        public List<FinancialStatementModel> NetOperatingProfit { get; set; }
        public List<FinancialStatementModel> ProfitBeforeIncomeTax { get; set; }
        public List<FinancialStatementModel> IncomeTaxForPeriod { get; set; }
        public List<FinancialStatementModel> TotalComprehensiveIncome { get; set; }
        public List<FinancialStatementModel> EquityIncrease { get; set; }
        public List<FinancialStatementModel> Equities { get; set; }

        public List<decimal> TotalAssets { get; set; }
        public List<decimal> TotalLiabilities { get; set; }
    }
}