using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {

        ApplicationDbContext c = new ApplicationDbContext();
        OtherMessageManager om = new OtherMessageManager(new EfOtherMessageRepository());
        /// <summary>
        /// Gelen Kutusu
        /// </summary>
        /// <returns></returns>
        public IActionResult Inbox()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = om.GetInboxListByWriter(writerID);
            return View(values);
        }
        public IActionResult SendBox()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = om.GetSendBoxListByWriter(writerID);
            return View(values);
        }
    }
}
