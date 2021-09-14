using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codefirst02.Models;

namespace Codefirst02.Controllers
{
    public class StudentController : Controller
    {
        LapTrinhQuanLyDBContext db = new LapTrinhQuanLyDBContext();
        // GET: Student
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        // tao action creat tra ve view cho phep nguoi dung nhap thong tin them moi Student
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Student std)
        {
            if(ModelState.IsValid)
            {
                db.Students.Add(std);
                db.SaveChanges();
                return RedirectToAction("Indext");

            }
            return View();
        }

    }
}