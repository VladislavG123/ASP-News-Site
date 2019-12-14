using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SiteNews.DataContext;
using SiteNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SiteNews.Areas.News.Controllers
{
    public class HomeController : Controller
    {
        // GET: News/Home
        public System.Web.Mvc.ActionResult Index()
        {
            using (var context = new NewsContext())
            {
                ViewBag.News = context.News.ToList();
                return View();
            }

        }

        public async Task<string> All()
        {
            using (var context = new NewsContext())
            {
                var data = await context.News.ToListAsync();

                return JsonConvert.SerializeObject(data);
            }
        }
    }
}