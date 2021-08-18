using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Areas.Admin.Controllers
{[Area("Admin")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Products u)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddPro(u);
            if (count > 0)
            {
                TempData["result"] = "Thêm sản phẩm thành công";
                return Redirect("ProductIndex");
            }
            else
            {
                TempData["result"] = "Thêm sản phẩm không thành công";
                return Redirect("ProductIndex");
            }
        }
        public IActionResult EditProduct(int Id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            Products s = context.GetProByMa(Id);
            ViewData.Model = s;
            return View();
        }
        public IActionResult EditProduct1(Products kh)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.UpdatePro(kh);
            if (count > 0)
            {
                TempData["result"] = "Sửa thành công";
                return Redirect("ProductIndex");
            }
            else
            {
                TempData["result"] = "Sửa không thành công";
                return Redirect("ProductIndex");
            }
        }
        public IActionResult DeleteProduct(int Id)
        {
            // ViewData["id"] = Id;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int count = context.XoaPro(Id);
            if (count > 0)
            {
                TempData["result"] = "Xóa thành công";
                return Redirect("ProductIndex");
            }
            else
            {
                TempData["result"] = "Xóa không thành công";
                return Redirect("ProductIndex");
            }
        }
        public IActionResult ProductIndex()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return View(context.GetSanPham());
        }
    }
}
