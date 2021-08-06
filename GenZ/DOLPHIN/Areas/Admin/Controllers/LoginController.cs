//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using DOLPHIN.DTO;
//using DOLPHIN.Model;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace DOLPHIN.Areas.Admin.Controllers
//{
//    [Area("Admin")]
//    public class LoginController : Controller
//    {
//        private readonly ApplicationDBContext _context;

//        public LoginController(ApplicationDBContext context)
//        {
//            _context = context;
//        }
//        public ActionResult Index()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Index(AccountDto account)
//        {
//            if (account == null)
//            {
//                return View();
//            }

//            if (ModelState.IsValid)
//            {
//                using (_context)
//                {
//                    var obj = _context.Users.Where(a => a.UserName.Equals(account.UserName) && a.Password.Equals(account.PassWord)).FirstOrDefault();
//                    if (obj != null)
//                    {
//                        var userId = HttpContext.Session.GetString("UserID");
//                        userId = obj.Id.ToString();
//                        var userName = HttpContext.Session.GetString("UserName");
//                        userName = obj.UserName.ToString();
//                        return Redirect("/Admin/Home/Index");
//                    }
//                }
//            }
//            return View(account);
//        }
//    }
//}
