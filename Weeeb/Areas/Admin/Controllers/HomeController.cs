using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Weeeb.Models;

namespace Weeeb.Areas.Admin.Controllers
{[Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMsg = TempData["result"];
            }
            WeeeebContext context = HttpContext.RequestServices.GetService(typeof(Weeeb.Models.WeeeebContext)) as WeeeebContext;
            ViewModel1 mymodel = new ViewModel1();
            mymodel.sp1 = context.GetTaiKhoan();
            mymodel.sp2 = context.GetEmail();
            mymodel.sp3 = context.GetCat();
            mymodel.sp4 = context.GetBra();
            return View(mymodel);
        }
    }
}
