using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Codefirst02.Models;


namespace Codefirst02.Controllers
{
    public class StdNewController : Controller
    {
        //khai bao DB context de lam viec voi Database
        private LapTrinhQuanLyDBContext db = new LapTrinhQuanLyDBContext();
        AutoGenerateKey genKey = new AutoGenerateKey();
        // GET: StdNew
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        public ActionResult Create()
        {
            var stdID = "";
            var countStudent = db.Students.Count();
            if (countStudent == 0)
            {
                stdID = "STD001";
            }
            else
            {

                // lay gia tri id moi nhat
                var studentID = db.Students.ToList().OrderByDescending(m => m.StudentID).FirstOrDefault().StudentID;
                //sinh studentId tu dong
                stdID = genKey.GenerateKey(studentID);
            }
            ViewBag.StudentID = stdID;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student Std)
        {
            if (ModelState.IsValid)
            { 
            //luu tt vao db
            db.Students.Add(Std);
            db.SaveChanges();
                //lay du lieu clien gui len va luu vao database
                return RedirectToAction("Index");
            }
            
            return View(Std);
        }

    }
}