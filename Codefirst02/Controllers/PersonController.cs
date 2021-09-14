using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Codefirst02.Models;

namespace Codefirst02.Controllers
{
    public class PersonController : Controller
    {
        //khai bao DB context de lam viec voi Database
        private LapTrinhQuanLyDBContext db = new LapTrinhQuanLyDBContext();

        // GET: Person
        public ActionResult Index()
        {
            //tra ve view Index kem theo list danh dach sach person trong DB
            return View(db.Person.ToList());
        }

        // GET: Person/Details/5
        public ActionResult Details(string id)
        {
            //neu id = null thi tra ve trang loi badrequest
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //tim kiem person theo id duoc gui len
            Person person = db.Person.Find(id);
            if (person == null)
            {
                //neu k co person thi tra ve not found
                return HttpNotFound();
            }
            // neu co person thif tra ve view kem theo thong tin person
            return View(person);
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            //tra ve view cho nguoi dung nhap thong tin
            return View();
        }

        // POST: Person/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //ho tro qly lam viec giua client va server
        [ValidateAntiForgeryToken]
        //nhan gia trij thuoc tinh ty client gui len
        public ActionResult Create([Bind(Include = "PersonID,PersonName,Address")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Person.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person);
        }

        // GET: Person/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Person.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: Person/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonID,PersonName,Address")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        // GET: Person/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.Person.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Person person = db.Person.Find(id);
            db.Person.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
