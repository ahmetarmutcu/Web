using BusinessLayer.Concrete;
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
        OtherMessageManager om = new OtherMessageManager(new EfOtherMessageRepository());
        public IViewComponentResult Invoke()
        {
            int id = 2;
            var values = om.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
