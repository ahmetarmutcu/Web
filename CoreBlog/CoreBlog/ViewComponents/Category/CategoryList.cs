﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.ViewComponents.Category
{
    public class CategoryList: ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
