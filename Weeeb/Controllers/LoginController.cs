using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weeeb.Models;

namespace Weeeb.Controllers
{
    public class LoginController : Controller
    {
        private WeeeebContext context;
        void setDBContext()
        {
            if (context == null)
                context = HttpContext.RequestServices.GetService(typeof(WeeeebContext)) as WeeeebContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            return View();
        }
        [HttpPost]
        public IActionResult Index(string email, string password)
        {

            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            int kq = context.Login(email, password);
            string a = context.GetFname(email, password);
            string uid = context.getUserId(email, password);
            TempData["userlogin"] = a;

            TempData["uid"] = uid;
            
            if (kq == 1)
            {
                return Redirect("/Admin/Home/Index");
                //return RedirectToAction("Index", "Home");
            }
            else if (kq == -1)
            {
                TempData["result"] = "Đăng nhập không thành công";
                return RedirectToAction("Index", "Login");
            }
            HttpContext.Session.SetString("flag","1");
            HttpContext.Session.SetString("username", a);
            HttpContext.Session.SetString("uid", uid);
            return Redirect("~/Home/Index1");
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User_Info u)
        {
            int count;
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            count = context.AddUser(u);
            if (count > 0)
            {
                TempData["result"] = "Thêm user thành công";
            }
            else
            {
                TempData["result"] = "Thêm user không thành công";
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return Redirect("~/Home/Index1");
        }
    }
}
