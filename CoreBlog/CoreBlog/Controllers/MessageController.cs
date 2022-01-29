using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        OtherMessageManager om = new OtherMessageManager(new EfOtherMessageRepository());
        public IActionResult InBox()
        {
            int id = 2;
            var values = om.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
