using BcProject.Models.Context;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BcProject.Controllers
{
     
    public class GalleryController : Controller
    {
        private readonly BcDbContext context = new BcDbContext();
        // GET: Gallery
        public ActionResult Index(int? id,int page=1)
        {

            if (id != null)
            {
                var pics = context.PictureLists.Where(i => i.WorksId == id).ToList().ToPagedList(page, 6);
                return View(pics);
            }

            else
            {
                var pics2 = context.PictureLists.ToList().ToPagedList(page,6);
                return View(pics2);
            }


        }
    }
}