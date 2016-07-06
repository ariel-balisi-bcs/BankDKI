using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankDKI.Models;
using BankDKI.DataLayer;

namespace BankDKI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        DKICreditRatingEntities entities = new DKICreditRatingEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            if (!entities.Users.Any(x => x.UserName == model.UserName && x.UserPassword == model.Password))
                return Json(new { Status = "Error", RedirectUrl = "" });

            Session["UserName"] = model.UserName;
            return Json(new { Status = "Sucess", RedirectUrl = Url.Action("Information", "Financial") });
        }
    }
}
