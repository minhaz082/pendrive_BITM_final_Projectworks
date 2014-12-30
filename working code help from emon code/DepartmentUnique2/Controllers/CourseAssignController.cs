using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DepartmentUnique2.Models;

namespace DepartmentUnique2.Controllers
{
    public class CourseAssignController : Controller
    {
        private TestDBcontext db = new TestDBcontext();

        // GET: /CourseAssign/
        public ActionResult Index()
        {
            var courseassigndbset = db.CourseAssignDbSet.Include(c => c.Courses).Include(c => c.Departments).Include(c => c.Teachers);
            return View(courseassigndbset.ToList());
        }

        // GET: /CourseAssign/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssign courseassign = db.CourseAssignDbSet.Find(id);
            if (courseassign == null)
            {
                return HttpNotFound();
            }
            return View(courseassign);
        }

        // GET: /CourseAssign/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.CourseDbSet, "CourseId", "CourseCode");
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name");
            ViewBag.TeacherId = new SelectList(db.TeacherDbSet, "TeacherId", "TeacherName");
            return View();
        }

        // POST: /CourseAssign/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CourseAssignId,DepartmentId,CourseId,TeacherId")] CourseAssign courseassign)
        {
            if (ModelState.IsValid)
            {
                db.CourseAssignDbSet.Add(courseassign);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.CourseDbSet, "CourseId", "CourseCode", courseassign.CourseId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name", courseassign.DepartmentId);
            ViewBag.TeacherId = new SelectList(db.TeacherDbSet, "TeacherId", "TeacherName", courseassign.TeacherId);
            return View(courseassign);
        }

        // GET: /CourseAssign/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssign courseassign = db.CourseAssignDbSet.Find(id);
            if (courseassign == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.CourseDbSet, "CourseId", "CourseCode", courseassign.CourseId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name", courseassign.DepartmentId);
            ViewBag.TeacherId = new SelectList(db.TeacherDbSet, "TeacherId", "TeacherName", courseassign.TeacherId);
            return View(courseassign);
        }

        // POST: /CourseAssign/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CourseAssignId,DepartmentId,CourseId,TeacherId")] CourseAssign courseassign)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseassign).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.CourseDbSet, "CourseId", "CourseCode", courseassign.CourseId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Name", courseassign.DepartmentId);
            ViewBag.TeacherId = new SelectList(db.TeacherDbSet, "TeacherId", "TeacherName", courseassign.TeacherId);
            return View(courseassign);
        }

        // GET: /CourseAssign/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssign courseassign = db.CourseAssignDbSet.Find(id);
            if (courseassign == null)
            {
                return HttpNotFound();
            }
            return View(courseassign);
        }

        // POST: /CourseAssign/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseAssign courseassign = db.CourseAssignDbSet.Find(id);
            db.CourseAssignDbSet.Remove(courseassign);
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

        public ActionResult GetCourseInfo(int courseID)
        {
            var courseInfo = db.CourseDbSet.Where(x => x.CourseId == courseID).FirstOrDefault();
            return Json(courseInfo, JsonRequestBehavior.AllowGet);
        }
    }
}
