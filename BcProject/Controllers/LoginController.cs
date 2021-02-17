using BcProject.Models;
using BcProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BcProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private readonly BcDbContext context = new BcDbContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(AdminUser p)
        {
           
                var datas = context.Admin.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);

                if (datas != null)
                {

                    FormsAuthentication.SetAuthCookie(datas.UserName, false);
                    Session["CurrentMail"] = datas.UserName.ToString();
                    return RedirectToAction("Index", "Admin");

                }

                else
                {

                    return RedirectToAction("Index", "Login");
                }

             
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            return RedirectToAction("Index", "Home");
        }
    }
}