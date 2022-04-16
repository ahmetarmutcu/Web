using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        ApplicationDbContext c = new ApplicationDbContext();
        OtherMessageManager om = new OtherMessageManager(new EfOtherMessageRepository());
        public IActionResult InBox()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = om.GetInboxListByWriter(writerID);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = om.GetById(id);
            return View(value);
        }

        public IActionResult SendBox()
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var values = om.GetSendBoxListByWriter(writerID);
            return View(values);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        public IActionResult SendMessage(OtherMessage p)
        {
            var userName = User.Identity.Name;
            var userMail = c.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            p.SenderID = writerID;
            //Buraya girilen mailin ID çeken kod girilecek.
            p.ReceiverID = 2;
            p.MessageStatus = true;
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            om.TAdd(p);
            return RedirectToAction("Inbox");
        }
    }
}
