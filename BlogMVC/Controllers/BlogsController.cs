using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMVC.Controllers
{
    public class BlogsController : Controller
    {
        WebAPIDBEntities webAPIDBEntities = new WebAPIDBEntities();
        // GET: Blogs
        public ActionResult Index()
        {

            var blogDetails = webAPIDBEntities.Blogs.ToList().OrderByDescending(x=>x.BId);
            return View(blogDetails);
        }
        public ActionResult Uploadblog()
        {

            return View();
        }
        [HttpPost]

        public ActionResult Uploadblog(Blog blog)
        {

            webAPIDBEntities.Blogs.Add(blog);
            webAPIDBEntities.SaveChanges();
            ViewBag.message = "Blog Details are saved Successfully...!";
             return View();
        }

        public ActionResult Food()
        {

            var foodArticle = webAPIDBEntities.Blogs.Where(x => x.BCategory == "Food");
            return View(foodArticle);
        }

        public ActionResult Sports()
        {

            var sportsArticle = webAPIDBEntities.Blogs.Where(x => x.BCategory == "Sports");
            return View(sportsArticle);
        }

        public ActionResult Movies()
        {
            var moviesArticle = webAPIDBEntities.Blogs.Where(x => x.BCategory == "Movies");
            return View(moviesArticle);
        }
    }

    
}