using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Controllers
{
    public class BrandController : Controller
    {
        private WeeeebContext context;
        void setDBContext()
        {
            if (context == null)
                context = HttpContext.RequestServices.GetService(typeof(WeeeebContext)) as WeeeebContext;
        }
        public IActionResult HP()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamBrand(1);
            ViewData.Model = s;
            return View();
        }
        public IActionResult Samsung()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamBrand(2);
            ViewData.Model = s;
            return View();
        }
        public IActionResult Apple()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamBrand(3);
            ViewData.Model = s;
            return View();
        }
        public IActionResult motorolla()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamBrand(4);
            ViewData.Model = s;
            return View();
        }
        public IActionResult LG()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamBrand(5);
            ViewData.Model = s;
            return View();
        }
        public IActionResult Cloth()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewBag.count1 = context.CountC(1);
            ViewBag.count2 = context.CountC(2);
            ViewBag.count3 = context.CountC(3);
            ViewBag.count4 = context.CountC(4);
            ViewBag.count5 = context.CountC(5);
            ViewBag.count6 = context.CountC(6);
            ViewBag.count7 = context.CountC(7);
            ViewBag.count11 = context.CountB(1);
            ViewBag.count22 = context.CountB(2);
            ViewBag.count33 = context.CountB(3);
            ViewBag.count44 = context.CountB(4);
            ViewBag.count55 = context.CountB(5);
            ViewBag.count66 = context.CountB(6);
            var s = context.GetSanPhamBrand(6);
            ViewData.Model = s;
            return View();
        }
    }
}
