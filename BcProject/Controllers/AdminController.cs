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
    public class AdminController : Controller
    {
        // GET: Admin
        private readonly BcDbContext context = new BcDbContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Project()
        {
            var model = context.Works.Where(x=>x.MenüControl==true).Select(I => new ProjectListModel
            {
                Id = I.Id,
                Description = I.Description,
                Title = I.Title,
                MenüControl=I.MenüControl

            }).ToList();
            return View(model);
        }
        public ActionResult EkleProje()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EkleProje(ProjectAddModel model)
        {
            if (ModelState.IsValid)
            {
                Works p = new Works();
                p.Id = model.Id;
                p.Title = model.Title;
                p.Description = model.Description;
                p.MenuPicture = model.MenuPicture;
                p.MenüControl = true;
                context.Works.Add(p);
                context.SaveChanges();
                return RedirectToAction("Project");
            }
            return View(model);

        }

        public ActionResult GuncelleProje(int? id)
        {
            if (id != null)
            {
                var model = context.Works.Where(x => x.Id == id).Select(y => new ProjectUpdateModel
                {
                    Id = y.Id,
                    Description = y.Description,
                    Title = y.Title,
                    MenuPicture = y.MenuPicture
                }).FirstOrDefault();

                return View(model);

            }
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public ActionResult GuncelleProje(ProjectUpdateModel model)
        {

            if (ModelState.IsValid)
            {
                var _model = context.Works.Find(model.Id);
                _model.Id = model.Id;
                _model.Description = model.Description;
                _model.Title = model.Title;
                _model.MenuPicture = model.MenuPicture;
                _model.MenüControl = true;
                context.SaveChanges();
                return RedirectToAction("Project");
            }

            else
            {
                return View(model);
            }
            
        }

        public ActionResult Sil(int id)
        {
            var model = context.Works.Find(id);
            model.MenüControl = false;
            context.SaveChanges();
            return RedirectToAction("Project");
        }
        public ActionResult EkleFoto(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public ActionResult EkleFoto(WorkPictureList p)
        {
            context.PictureLists.Add(p);
            context.SaveChanges();
            return RedirectToAction("Project");


        }
        public ActionResult AdminGuncelle()
        {
            var model = context.Admin.Where(x => x.Id == 1).Select(y => new AdminUpdate
            {
                Id = y.Id,
                Adress = y.Adress,
                Mail = y.Mail,
                Number = y.Number,
                Password = y.Password,
                UserName = y.UserName

            }).FirstOrDefault();

            return View(model);
        }
        [HttpPost]
        public ActionResult AdminGuncelle(AdminUpdate model)
        {
            if (ModelState.IsValid)
            {
                var _model = context.Admin.Find(model.Id);
                _model.Id = model.Id;
                _model.UserName = model.UserName;
                _model.Adress = model.Adress;
                _model.Password = model.Password;
                _model.Mail = model.Mail;
                _model.Number = model.Number;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}