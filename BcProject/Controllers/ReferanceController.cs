using BcProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BcProject.Controllers
{
    
    public class ReferanceController : Controller
    {
        private readonly BcDbContext context = new BcDbContext();
        // GET: Referance
        public ActionResult Index()
        {
            var dgr = context.Works.Where(x=>x.MenüControl==true).ToList();
            
            return View();
        }
    }
}