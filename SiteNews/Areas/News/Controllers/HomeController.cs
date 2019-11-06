using SiteNews.DataContext;
using SiteNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteNews.Areas.News.Controllers
{
    public class HomeController : Controller
    {
        // GET: News/Home
        public ActionResult Index()
        {
            using(var context = new NewsContext())
            {
                ViewBag.News = context.News.ToList(); 
                return View();
            }
                
        }
    }
}