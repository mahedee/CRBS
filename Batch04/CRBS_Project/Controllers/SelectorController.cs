using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRBS_Project.Controllers
{
    public class SelectorController : Controller
    {

        [HttpPost]
        public ActionResult Search(string name = "mahedee")
        {
            string msg = Server.HtmlEncode(name);
            return Content(msg);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return Content("This without parameter!");
        } 
        // GET: Selector
        [OutputCache(Duration = 20, VaryByParam = "none")]
        public ActionResult Index()
        {
            ViewBag.Message = DateTime.Now.ToString();
            return View();
        }

        // GET: Selector/Details/5
        
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: Selector/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Selector/Create
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

        // GET: Selector/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Selector/Edit/5
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

        // GET: Selector/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Selector/Delete/5
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
