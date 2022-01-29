using ClosedXML.Excel;
using CoreBlog.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";
                int blogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(blogRowCount, 1).Value = item.ID;
                    worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
                    blogRowCount++;
                }
                using(var stream=new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","Calisma1.xlsx");
                }
            }
        }
        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel{ID=1,BlogName="C# programlamaya giriş"},
                new BlogModel{ID=2,BlogName="Tesla Firmasının Araçları"},
                new BlogModel{ID=3,BlogName="2020 Olimpiyatları"}
            };
            return bm;
        }

        [Authorize]
        public IActionResult BlogListExcel()
        {
            return View();
        }
    }
}
