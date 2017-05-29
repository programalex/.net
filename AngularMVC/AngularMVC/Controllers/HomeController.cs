using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() 
        {
            return View();
        }
        public JsonResult GetProducts(){
            var db = new ProsuctsDBEntities();
            var products = db.Products.ToList();
            return Json(products, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult AddProduct(string newProduct)
        {
            var db = new ProsuctsDBEntities();
            db.Products.Add(new Product() { ProductName = newProduct });
            db.SaveChanges();
            var products = db.Products.ToList();
            return Json(products, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult DeleteProduct(Product delProduct)
        {
            var db = new ProsuctsDBEntities();
            var product = db.Products.Find(delProduct.Id);
            db.Products.Remove(product);
            db.SaveChanges();
            var products = db.Products.ToList();
            return Json(products, JsonRequestBehavior.AllowGet);
        }
    }
}