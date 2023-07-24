using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.DataModels;

namespace WebApplication1.Areas.Client.Controllers
{
    public class AccountController : Controller
    {
        private BookShopEntities db = new BookShopEntities();
        // GET: Client/Account
        public ActionResult Index()
        {
            if (Session["Email"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Login(string email, string password)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var data = db.Account.Where(s => s.Email.Equals(email) && s.Password.Equals(password)).ToList();
        //        if (data.Count() > 0)
        //        {
        //            add session
        //            Session["Email"] = data.FirstOrDefault().Email;
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            ViewBag.error = "Login failed";
        //            return RedirectToAction("Login");
        //        }
        //    }
        //    return View();
        //}
    }
}