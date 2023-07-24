using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
//using WebApplication1.Models.DataModels;
using WebApplication1.Models.Entity;
using WebApplication1.Context;
namespace WebApplication1.Areas.Admin.Controllers
{
    public class BooksController : Controller
    {
        private Models.DataModels.BookShopEntities db = new Models.DataModels.BookShopEntities();

        private readonly projectDBContext context = new projectDBContext();
        // GET: Admin/Books
        public ActionResult Index()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book
            {
                //Id = 1,
                Name = "Hello, My Name Is Ice Cream: The Art and Science of the Scoop: A Cookbook",
                Author = "Louis",
                Description = "Hello, My Name Is Ice Cream: The Art and Science of the Scoop: A Cookbook",
                Price = 500000,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            books.Add(new Book
            {
                //Id = 2,
                Name = "Big Gay Ice Cream: Saucy Stories & Frozen Treats: Going All the Way with Ice Cream: A Cookbook",
                Author = "Hoang Cong Chien",
                Description = "Big Gay Ice Cream: Saucy Stories & Frozen Treats: Going All the Way with Ice Cream: A Cookbook",
                Price = 700000,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            books.Add(new Book
            {
                //Id = 3,
                Name = "Gelupo Gelato: A delectable palette of ice cream recipes",
                Author = "Nguyen Thi Hue",
                Description = "Gelupo Gelato: A delectable palette of ice cream recipes ",
                Price = 1000000,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            books.Add(new Book
            {
                //Id = 4,
                Name = "Salt & Straw Ice Cream Cookbook",
                Author = "Louis",
                Description = "Salt & Straw Ice Cream Cookbook",
                Price = 800000,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            books.Add(new Book
            {
                //Id = 5,
                Name = "Food52 Ice Cream and Friends: 60 Recipes and Riffs",
                Author = "Louis",
                Description = "Food52 Ice Cream and Friends: 60 Recipes and Riffs",
                Price = 300000,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            List<Recipe> recipes = new List<Recipe>();
            recipes.Add(new Recipe
            {
                //Id = 1,
                Name = "Classic Custard Ice Cream Base",
                Description = "Classic Custard Ice Cream Base",
                AccessType = 0,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            recipes.Add(new Recipe
            {
                //Id = 2,
                Name = "Simple Vanila Ice Cream",
                Description = "Simple Vanila Ice Cream",
                AccessType = 0,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            recipes.Add(new Recipe
            {
                //Id = 3,
                Name = "Cookie Monster Ice Cream",
                Description = "Cookie Monster Ice Cream",
                AccessType = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            recipes.Add(new Recipe
            {
                //Id = 4,
                Name = "Salted Caramel Ice Cream",
                Description = "Salted Caramel Ice Cream",
                AccessType = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            recipes.Add(new Recipe
            {
                //Id = 5,
                Name = "Strawberry Shortcake Ice Cream",
                Description = "Strawberry Shortcake Ice Cream",
                AccessType = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });

            List<Flavour> flavours = new List<Flavour>();
            flavours.Add(new Flavour
            {
                //Id = 1,
                Name = "Vanilla",
                Description = "Vanilla",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 2,
                Name = "Chocolate",
                Description = "Chocolate",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 3,
                Name = "Chocolate chip",
                Description = "Chocolate chip",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 4,
                Name = "Strawberry",
                Description = "Strawberry",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 5,
                Name = "Mango",
                Description = "Mango",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 6,
                Name = "Coffee",
                Description = "Coffee",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 7,
                Name = "Black currant",
                Description = "Black currant",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 8,
                Name = "Cherry",
                Description = "Cherry",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 9,
                Name = "Butterscotch",
                Description = "Butterscotch",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 10,
                Name = "Walnut",
                Description = "Walnut",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 11,
                Name = "Vanilla and strawberry (two in one)",
                Description = "Vanilla and strawberry (two in one)",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 12,
                Name = "Pistachio",
                Description = "Pistachio",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 13,
                Name = "Banana",
                Description = "Banana",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 14,
                Name = "Banana Chocolate chip",
                Description = "Banana Chocolate chip",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 15,
                Name = "Chocolate almond",
                Description = "Chocolate almond",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 16,
                Name = "Chocolate truffle",
                Description = "Chocolate truffle",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 17,
                Name = "Kiwi fruit",
                Description = "Kiwi fruit",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 18,
                Name = "Pineapple",
                Description = "Pineapple",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 19,
                Name = "Fruit and nut",
                Description = "Fruit and nut",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            flavours.Add(new Flavour
            {
                //Id = 20,
                Name = "Cashew Caramel crunch",
                Description = "Cashew Caramel crunch",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });

            List<UserAccount> users = new List<UserAccount>();
            users.Add(new UserAccount
            {
                //Id = 1,
                Name = "Louis",
                Email = "duclongdo1997@gmail.com",
                PhoneNumber = "0375326233",
                Description = "Hello, I'm Louis Handsome",
                Password = "25031997",
                Type = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            users.Add(new UserAccount
            {
                //Id = 2,
                Name = "Hoang Cong Chien",
                Email = "prolagicoanduockhong@gmail.com",
                PhoneNumber = "1111111111",
                Description = "TPM Hoang Cong Chien",
                Password = "1",
                Type = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            users.Add(new UserAccount
            {
                //Id = 3,
                Name = "Nguyen Thi Hue",
                Email = "huenguyenthi@gmail.com",
                PhoneNumber = "2222222222",
                Description = "Hue xinh gai",
                Password = "25031997",
                Type = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
            });
            users.Add(new UserAccount
            {
                //Id = 4,
                Name = "Thao Muoi",
                Email = "thuthaopham1998@gmail.com",
                PhoneNumber = "0365619881",
                Description = "Thao Muoi xinh gai dang yeu",
                Password = "14081998",
                Type = 2,
                BudgetId = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1,
               
            });

            List<Budget> budgets = new List<Budget>();
            budgets.Add(new Budget
            {
                //Id = 1,
                UserId = 4,
                Balance = 1000000000000
                //UserAccount = context.UserAccounts.Where(us => us.Id == 4).First()

            });

            /*context.Books.AddRange(books);
            context.Recipes.AddRange(recipes);
            context.Flavours.AddRange(flavours);
            context.UserAccounts.AddRange(users);*/
            context.Budgets.AddRange(budgets);
            /*context.UserAccounts.Add(new UserAccount
            {
                //Id = 4,
                Name = "Thao Muoi",
                Email = "thuthaopham1998@gmail.com",
                PhoneNumber = "0365619881",
                Description = "Thao Muoi xinh gai dang yeu",
                Password = "14081998",
                Type = 2,
                BudgetId = 1,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                UserCreatedId = 1,
                UserModifyId = 1
                //Budget = null
               *//* Budget = new Budget
                {
                    //Id = 1,
                    //UserId = 6,
                    Balance = 1000000000000
                    //UserAccount = context.UserAccounts.Where(us => us.Id == 4).First()

                }*//*
            });*/
            context.SaveChanges();
            var bookse = db.Books.Include(b => b.Category).Include(b => b.Publisher);
            return View(books.ToList());
        }

        // GET: Admin/Books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.DataModels.Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // GET: Admin/Books/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name");
            ViewBag.PublisherId = new SelectList(db.Publishers, "Id", "Name");
            return View();
        }

        // POST: Admin/Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Author,Release,Price,Description,Picture,CategoryId,PublisherId")] Models.DataModels.Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", book.CategoryId);
            ViewBag.PublisherId = new SelectList(db.Publishers, "Id", "Name", book.PublisherId);
            return View(book);
        }

        // GET: Admin/Books/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.DataModels.Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", book.CategoryId);
            ViewBag.PublisherId = new SelectList(db.Publishers, "Id", "Name", book.PublisherId);
            return View(book);
        }

        // POST: Admin/Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Author,Release,Price,Description,Picture,CategoryId,PublisherId")] Models.DataModels.Book book)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(book).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Name", book.CategoryId);
            ViewBag.PublisherId = new SelectList(db.Publishers, "Id", "Name", book.PublisherId);
            return View(book);
        }

        // GET: Admin/Books/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.DataModels.Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        // POST: Admin/Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Models.DataModels.Book book = db.Books.Find(id);
            db.Books.Remove(book);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
