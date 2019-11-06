using SiteNews.DataContext;
using SiteNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteNews.Areas.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        // GET: AdminPanel/Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string text, string imageUrl)
        {
            using(var context = new NewsContext())
            {
                context.News.Add(new Models.News { Text = text, ImagePath = imageUrl });
                context.SaveChanges();
            }
            return View();
        }
    }
}