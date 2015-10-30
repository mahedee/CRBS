using CRBS_Project.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRBS_Project.Controllers
{
    [Log] 
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search()
        {
            //string value = "";
            //int x = Convert.ToInt32(value);
            //return View();
            throw new Exception("Something terrible has happend!");
            return Content("This without parameter!"); 
        }
        //public JsonResult Search(string title = "Object Oriented Programming with C#")
        //{
        //    //string msg = Url.Encode(title); 
        //    return Json(new { Id = 1, Title = title, Body = "List of Topics" },JsonRequestBehavior.AllowGet);
        //}
        //public FileResult Search(string title = "About CSS")
        //{
        //    return File(Server.MapPath("~/Content/site.css"), "text/css");
        //}
        //public RedirectToRouteResult Search(string title = "About me")
        //{
        //    return RedirectToRoute("Default", new {controller = "Home",action = "About"});
        //}
        //public ActionResult Search(string title = "Default parameter")
        //{
        //    return RedirectToAction("About", "Home");
        //}
        //public ActionResult Search(string name = "Default parameter")
        //{
        //    return RedirectToAction("Index", "Home", new { title = name });
        //} 
        //public ActionResult Search(string title = "Default parameter")
        //{
        //    return RedirectPermanent("http://mahedee.net");
        //}
        //public ActionResult Search()
        //{
        //    return Content("Hello");
        //}
        //public ActionResult Search(string name)
        //{
        //    var message = Server.HtmlEncode(name);
        //    return Content(message);
        //} 
        //public ActionResult Search(string name = "Default parameter")
        //{
        //    var message = Server.HtmlEncode(name);
        //    return Content(message);
        //}
        // GET: Cuisine/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cuisine/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cuisine/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuisine/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cuisine/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuisine/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cuisine/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
