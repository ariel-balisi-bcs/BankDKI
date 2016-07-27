using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankDKI.Controllers
{
    public class FinancialStatementsController : Controller
    {
        //
        // GET: /FinancialStatements/

        public ActionResult StandAlone()
        {
            return View();
        }

        //
        // GET: /FinancialStatements/

        public ActionResult Combination()
        {
            return View();
        }

    }
}
