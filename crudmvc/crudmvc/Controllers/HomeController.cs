using crudmvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudmvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetDatos(){

            var db = new CrudDBmvcangularEntities();
            var datosr = db.datos.ToList();
            return Json(datosr, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult AddDato(string newdatos)
        {
            var db = new CrudDBmvcangularEntities();
            db.datos.Add(new dato() { Datos = newdatos });
            db.SaveChanges();
            var datosr = db.datos.ToList();
            return Json(datosr, JsonRequestBehavior.AllowGet);
        }
    }
}