using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Connection;

namespace Conectar.Controllers
{
    public class CrudUsuarioController : Controller
    {
        private ModelConnection db = new ModelConnection();

        // GET: CrudUsuario
        public ActionResult Index()
        {
            return View(db.consept.ToList());
        }

        // GET: CrudUsuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            consept consept = db.consept.Find(id);
            if (consept == null)
            {
                return HttpNotFound();
            }
            return View(consept);
        }

        // GET: CrudUsuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CrudUsuario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumeroIdentificacion,TipoDocumento,Nombre,Fecha")] consept consept)
        {
            if (ModelState.IsValid)
            {
                db.consept.Add(consept);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consept);
        }

        // GET: CrudUsuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            consept consept = db.consept.Find(id);
            if (consept == null)
            {
                return HttpNotFound();
            }
            return View(consept);
        }

        // POST: CrudUsuario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumeroIdentificacion,TipoDocumento,Nombre,Fecha")] consept consept)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consept).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consept);
        }

        // GET: CrudUsuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            consept consept = db.consept.Find(id);
            if (consept == null)
            {
                return HttpNotFound();
            }
            return View(consept);
        }

        // POST: CrudUsuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            consept consept = db.consept.Find(id);
            db.consept.Remove(consept);
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
