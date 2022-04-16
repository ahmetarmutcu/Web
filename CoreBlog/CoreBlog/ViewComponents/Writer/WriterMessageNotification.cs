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
    public class WriterMessageNotification : ViewComponent
    {
        ApplicationDbContext c = new ApplicationDbContext();
        OtherMessageManager om = new OtherMessageManager(new EfOtherMessageRepository());
        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = om.GetInboxListByWriter(writerID);
            return View(values);
        }
    }
}
