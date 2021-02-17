using BcProject.Models;
using BcProject.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BcProject.Controllers
{
    [Authorize]
    public class PicturesController : Controller
    {
        // GET: Pictures
        private readonly BcDbContext context = new BcDbContext();
        public ActionResult Index()
        {


            return View();
        }

        public ActionResult Ekle()
        {
            //List<SelectListItem> dropListProje = (from x in context.Works.ToList()
            //                                     select new SelectListItem
            //                                     {
            //                                         Text = x.Title,

            //                                         Value = x.Id.ToString()
            //                                     }).ToList();

            List<SelectListItem> dropListProje = context.Works.Where(x => x.MenüControl == true).Select(z => new SelectListItem
            {
                Text = z.Title,
                Value = z.Id.ToString()
            }).ToList();

            ViewBag.ktgid = dropListProje;
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(WorkPictureList model)
        {
            if (ModelState.IsValid)
            {
                context.PictureLists.Add(model);
                context.SaveChanges();
                return RedirectToAction("Ekle");
            }
            else
            {
                return View(model);
            }
        }

    }
}