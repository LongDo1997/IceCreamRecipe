using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.DataModels;

namespace WebApplication1.Areas.Client.Controllers
{
    public class HomeController : Controller
    {
        private BookShopEntities db = new BookShopEntities();
        // GET: Client/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Shop()
        {
            var books = db.Books.Include(b => b.Category).Include(b => b.Publisher);
            return View(books.ToList());
        }

        public ActionResult DetailProduct(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);

        }
    }
}