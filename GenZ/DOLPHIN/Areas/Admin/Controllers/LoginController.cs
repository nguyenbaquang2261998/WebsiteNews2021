using System;
using System.Linq;
using DOLPHIN.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DOLPHIN.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LoginController(ApplicationDBContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (user == null)
            {
                return View();
            }

            if (ModelState.IsValid)
            {
                using (_context)
                {
                    var obj = _context.User.Where(a => a.UserName.Equals(user.UserName) && a.PassWord.Equals(user.PassWord)).FirstOrDefault();
                    if (obj != null)
                    {
                        var userId = HttpContext.Session.GetString("UserID");
                        userId = obj.Id.ToString();
                        var userName = HttpContext.Session.GetString("UserName");
                        userName = obj.UserName.ToString();
                        return Redirect("/Admin/Home/Index");
                    }
                }
            }
            return View(user);
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}
