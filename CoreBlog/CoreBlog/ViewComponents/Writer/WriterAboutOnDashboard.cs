using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var userEmail = User.Identity.Name;
            ApplicationDbContext c = new ApplicationDbContext();
            var writerID = c.Writers.Where(x => x.WriterMail == userEmail).Select(y => y.WriterID).FirstOrDefault();
            var values = wm.GetWriterById(writerID);
            return View(values);
        }
    }
}
