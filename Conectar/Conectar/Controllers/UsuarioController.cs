using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Connection;
using System.Web.Mvc;



namespace Conectar.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario

        
        public ActionResult Index()
        {
            var q = new UserBussiness();
            return View(q.GetAll());
                                   
        }
    }
}
