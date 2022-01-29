using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        ApplicationDbContext dbContext = new ApplicationDbContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = dbContext.Blogs.Count();
            ViewBag.v2 = dbContext.Contacts.Count();
            ViewBag.v3 = dbContext.Comments.Count();
            return View();
        }
    }
}
