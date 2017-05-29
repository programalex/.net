using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConectarLINQ.Models;


namespace ConectarLINQ.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public UsuarioModel model = new UsuarioModel();
        public ActionResult Index()
        {
            return View(model.ListarUsuario());
        }
        public ActionResult Details(int id)
        {
            var consept = model.BuscarUsuario(id);
            return View(consept);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(consept c)
        {
            try
            {
                if (model.InsertarUsuario(c).Equals("ok"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Create");
                }
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var consept = model.BuscarUsuario(id);
            return View(consept);
        }
        [HttpPost]
        public ActionResult Edit(int id, consept c)
        {
            try
            {
                consept consept = new consept();
                consept.NumeroIdentificacion = id;
                consept.TipoDocumento = c.TipoDocumento;
                consept.Nombre = c.Nombre;
                consept.Fecha = c.Fecha;

                if (model.ActualizarUsuario(consept).Equals("ok"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Edit");
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var consept = model.EliminarUsuario(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                if (model.EliminarUsuario(id).Equals("ok"))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Delete");
                }
            }
            catch
            {
                return View();
            }
        }

    }

}