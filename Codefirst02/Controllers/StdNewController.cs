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
        // GET: StdNew
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}