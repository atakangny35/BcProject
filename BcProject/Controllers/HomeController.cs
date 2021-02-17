using BcProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BcProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly BcDbContext context = new BcDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            var contact = context.Admin.FirstOrDefault();
            

            return View(contact);
        }
        public ActionResult Referance()
        {
            var referans = context.Works.Where(X=>X.MenüControl==true).ToList();
           
            
            return View(referans);
        }
        public PartialViewResult footer()
        {
            var info = context.Admin.FirstOrDefault();
            

            return PartialView(info);
        }
    }
}