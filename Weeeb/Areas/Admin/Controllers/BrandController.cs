using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        [HttpGet]
        public IActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBrand(Brands u)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddBra(u);
            if (count > 0)
            {
                TempData["result"] = "Thêm brand thành công";
                return Redirect("BrandIndex");
            }
            else
            {
                TempData["result"] = "Thêm brand không thành công";
                return Redirect("BrandIndex");
            }
        }
        public IActionResult EditBrand(int Id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            Brands s = context.GetBraByMa(Id);
            ViewData.Model = s;
            return View();
        }
        public IActionResult EditBrand1(Brands kh)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.UpdateBra(kh);
            if (count > 0)
            {
                TempData["result"] = "Sửa thành công";
                return Redirect("BrandIndex");
            }
            else
            {
                TempData["result"] = "Sửa không thành công";
                return Redirect("BrandIndex");
            }
        }
        public IActionResult DeleteBrand(int Id)
        {
            // ViewData["id"] = Id;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int count = context.XoaBra(Id);
            if (count > 0)
            {
                TempData["result"] = "Xóa thành công";
                return Redirect("BrandIndex");
            }
            else
            {
                TempData["result"] = "Xóa không thành công";
                return Redirect("BrandIndex");
            }
        }
        public IActionResult BrandIndex()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return View(context.GetBra());
        }
    }
}
