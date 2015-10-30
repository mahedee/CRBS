using CRBS_Project.Models;
using CRBS_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRBS_Project.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            CRBSystemContext db = new CRBSystemContext();
            //IEnumerable<Dashboard> model = null;
            // model = getVerifydetails(id);
            // return View(objcpModel);
            //List<Dashboard> lstDashboard = new List<Dashboard>(); 

            var prQuery = (from p in db.ConferenceRoomInfoModels
                           join pt in db.PropertyTypeInfo on p.PropertyPurposeId equals pt.PropertyPurposeId
                           join rt in db.RoomType on p.RoomTypeId equals rt.RoomTypeId

                           orderby p.PropertyId ascending
                           select new Dashboard
                           {
                               PropertyId = p.PropertyId,
                               PropertyName = p.PropertyName,
                               PersonCapacity = p.PersonCapacity,
                               PropertyPurposeId = p.PropertyPurposeId,
                               PropertyPurposeName = pt.PropertyPurposeName,
                               RoomTypeId = p.RoomTypeId,
                               RoomTypeName = rt.RoomTypeName,
                               FairAmount = p.FairAmount
                           });

            //var deshboard=db.ConferenceRoomInfoModels.Include(p=>p.PropertyTypeInfo)
            //lstDashboard = prQuery.ToList();

            //DashboardViewData dashboardViewData = new DashboardViewData();
            //dashboardViewData.ConferenceRoomInfoModelsData = (from p in db.ConferenceRoomInfoModels select p.PropertyId);
            //dashboardViewData.PropertyTypeInfoData = from pt in db.PropertyTypeInfo select pt;
            //dashboardViewData.RoomTypeData = from rt in db.RoomType select rt;

            //return View(dashboardViewData);
            //where p.PropertyId == 1

            List<Dashboard> lstDashBoard = prQuery.ToList();

            return View(lstDashBoard);
        }

        // GET: Dashboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dashboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Create
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

        // GET: Dashboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dashboard/Edit/5
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

        // GET: Dashboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dashboard/Delete/5
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
