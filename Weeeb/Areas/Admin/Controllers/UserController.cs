using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Controllers
{[Area("Admin")]
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(User_Info u)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddUser(u);
            if (count > 0)
            {
                TempData["result"] = "Thêm user thành công";
                return Redirect("UserIndex");
            }
            else
            {
                TempData["result"] = "Thêm user không thành công";
                return Redirect("UserIndex");
            }
        }
        public IActionResult EditUser(int Id)
        {
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            User_Info s = context.GetTaiKhoanByMa(Id);
            ViewData.Model = s;
            return View();
        }
        public IActionResult EditUser1(User_Info kh)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.UpdateUser(kh);
            if (count > 0)
            {
                TempData["result"] = "Sửa thành công";
                return Redirect("UserIndex");
            }
            else
            {
                TempData["result"] = "Sửa thành công";
                return Redirect("UserIndex");
            }
        }
        public IActionResult DeleteUser(int Id)
        {
            // ViewData["id"] = Id;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int count = context.XoaUser(Id);
            if (count > 0)
            {
                TempData["result"] = "Xóa thành công";
                return Redirect("UserIndex");
            }
            else
            {
                TempData["result"] = "Xóa không thành công";
                return Redirect("UserIndex");
            }
        }
        public IActionResult UserIndex()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            return View(context.GetTaiKhoan());
        }
    }
}
