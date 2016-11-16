using InsuranceService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace InsuranceService.Controllers
{
    public class VehicleController : Controller
    {
        private InsuranceContext insctx;
        // GET: Vehicle
        public ActionResult Index()
        {
            insctx = new InsuranceContext();
            var data = from Vehicle v in insctx.Vehicles.ToList()
                       select v;

            var json = new JavaScriptSerializer().Serialize(data);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}