using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Categories u)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddCat(u);
            if (count > 0)
            {
                TempData["result"] = "Thêm thành công";
                return Redirect("CatIndex");
            }
            else
            {
                TempData["result"] = "Thêm không thành công";
                return Redirect("CatIndex");
            }
        }
        public IActionResult EditCat(int Id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            Categories s = context.GetCatByMa(Id);
            ViewData.Model = s;
            return View();
        }
        public IActionResult EditCat1(Categories kh)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.UpdateCat(kh);
            if (count > 0)
            {
                TempData["result"] = "Sửa thành công";
                return Redirect("CatIndex");
            }
            else
            {
                TempData["result"] = "Sửa không thành công";
                return Redirect("CatIndex");
            }
        }
        public IActionResult DeleteCat(int Id)
        {
            // ViewData["id"] = Id;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int count = context.XoaCat(Id);
            if (count > 0)
            {
                TempData["result"] = "Xóa thành công";
                return Redirect("CatIndex");
            }
            else
            {
                TempData["result"] = "Xóa không thành công";
                return Redirect("CatIndex");
            }
        }
        public IActionResult CatIndex()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return View(context.GetCat());
        }
    }
}
