using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmailController : Controller
    {
        public IActionResult EmailIndex()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return View(context.GetEmail());
        }
        [HttpGet]
        public IActionResult CreateEmail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEmail(Email_Info u)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddEmail(u);
            if (count > 0)
            {
                TempData["result"] = "Thêm email thành công";
                return Redirect("EmailIndex");
            }
            else
            {
                TempData["result"] = "Thêm email không thành công";
                return Redirect("EmailIndex");
            }
        }
        public IActionResult EditEmail(int Id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            Email_Info s = context.GetEmailByMa(Id);
            ViewData.Model = s;
            return View();
        }
        public IActionResult EditEmail1(Email_Info kh)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.UpdateEmail(kh);
            if (count > 0)
            {
                TempData["result"] = "Sửa thành công";
                return Redirect("EmailIndex");
            }
            else
            {
                TempData["result"] = "Sửa không thành công";
                return Redirect("EmailIndex");
            }
        }
        public IActionResult DeleteEmail(int Id)
        {
            // ViewData["id"] = Id;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int count = context.XoaEmail(Id);
            if (count > 0)
            {
                TempData["result"] = "Xóa thành công";
                return Redirect("EmailIndex");
            }
            else
            {
                TempData["result"] = "Xóa không thành công";
                return Redirect("EmailIndex");
            }
        }
    }
}
