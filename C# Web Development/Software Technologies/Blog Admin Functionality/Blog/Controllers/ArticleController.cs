using Blog.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: Article
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        //
        // GET: Article/List
        public ActionResult List()
        {
            using (var database = new BlogDbContext())
            {
                var articles = database.Articles
                    .Include(a => a.Author)
                    .ToList();

                return View(articles);
            }
        }

        //
        // GET: Article/Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var database = new BlogDbContext())
            {
                var article = database.Articles
                    .Where(a => a.Id == id)
                    .Include(a => a.Author)
                    .First();

                if (article == null)
                {
                    return HttpNotFound();
                }

                return View(article);
            }
        }

        //
        // GET: Article/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: Article/Create
        [HttpPost]
        [Authorize]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                using (var database = new BlogDbContext())
                {
                    var authorId = database.Users
                        .Where(u => u.UserName == this.User.Identity.Name)
                        .First()
                        .Id;

                    article.AuthorId = authorId;

                    database.Articles.Add(article);
                    database.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(article);
        }

        [HttpGet]
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var db = new BlogDbContext();

            var article = db.Articles.Find(id);

            if (!IsUserAuthorizedToEdit(article))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            if (article == null)
            {
                return HttpNotFound();
            }

            return View(article);
        }

        [HttpPost]
        [ActionName("Delete")]
        [Authorize]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var db = new BlogDbContext();

            var article = db.Articles.Find(id);

            if (article == null)
            {
                return HttpNotFound();
            }

            db.Articles.Remove(article);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var db = new BlogDbContext();

            var article = db.Articles.Find(id);

            if (!IsUserAuthorizedToEdit(article))
            {
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            if (article == null)
            {
                return HttpNotFound();
            }

            var model = new ArticleViewModel();

            model.Id = article.Id;
            model.Title = article.Title;
            model.Content = article.Content;

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Edit(ArticleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var db = new BlogDbContext();

                var article = db.Articles.Find(model.Id);

                article.Title = model.Title;
                article.Content = model.Content;

                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model);
        }

        private bool IsUserAuthorizedToEdit(Article article)
        {
            bool isAdmin = this.User.IsInRole("Admin");
            bool isAuthor = article.IsAuthor(this.User.Identity.Name);

            return isAdmin || isAuthor;
        }
    }
}