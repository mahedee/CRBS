using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRBS_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("Details")]
        public ActionResult About(int id=0)
        {
            //ViewBag.Message = "Your application description page.";
            if(id==1)
            {
                ViewBag.CompanyName="Leadsosft Bangladesh Ltd.";
                ViewBag.Founder = "Leadsosft Bangladesh Ltd.";
                ViewBag.Address = "Purana Polton.";
            }
            else
            {
                ViewBag.CompanyName = "General Software Solutions";
                ViewBag.Founder = "Rukunzzaman";
            }
            return View("About");
        }
        
        //E:\Tareq\Static_CRBS_Solution\CRBS_Project\Views\Home\About.cshtml

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            ActionResult obj = About();

            return View(obj);
        }
    }
}