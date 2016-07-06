using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankDKI.DataLayer;
using BankDKI.Models;

namespace BankDKI.Controllers
{
    public class CreditAnalysisController : Controller
    {
        //
        // GET: /CreditAnalysis/
        DKICreditRatingEntities entities = new DKICreditRatingEntities();
        public ActionResult Index()
        {
            var creditReportHistory = entities.CreditRatingHistories.First();
            var creditRatingHistoryModel = new CreditRatingHistoryModel
            {
                Id = creditReportHistory.Id,
                UserId = creditReportHistory.UserId,
                Description = creditReportHistory.Description,
                PaymentHistory = creditReportHistory.PaymentHistory,
                AmountDebit = creditReportHistory.AmountDebit,
                LengthCrditHistory = creditReportHistory.LengthCreditHistory,
                Comments = creditReportHistory.Comment
            };
            return View(creditRatingHistoryModel);
        }

        [HttpPost]
        public ActionResult SaveCreditAnalysisReport(CreditRatingHistoryModel model)
        {
            var creditRatingTable = new CreditRatingHistory()
            {
                Id = model.Id,
                UserId = model.UserId,
                Description = model.Description,
                PaymentHistory = model.PaymentHistory,
                AmountDebit = model.AmountDebit,
                LengthCreditHistory = model.LengthCrditHistory,
                Comment = model.Comments
            };

            entities.CreditRatingHistories.Attach(creditRatingTable);
            entities.Entry(creditRatingTable).State = System.Data.EntityState.Modified;
            entities.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
