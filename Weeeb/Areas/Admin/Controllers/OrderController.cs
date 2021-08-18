using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        /*
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
                ViewData["thongbao"] = kh.brand_id;
            else
                ViewData["thongbao"] = kh.brand_id;
            return View();
        }
        */
        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View();
        }
        public IActionResult OrderIndex()
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return View(context.GetOrders());
        }
        public IActionResult DeleteOrder(int Id)
        {
            // ViewData["id"] = Id;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int count = context.XoaOrder(Id);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
    }
}
