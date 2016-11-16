using InsuranceService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace InsuranceService.Controllers
{
    public class PoliciesController : Controller
    {
        private InsuranceContext insctx;
        // GET: Policies
        public ActionResult Index()
        {
            insctx = new InsuranceContext();

            var data= from Policy p in insctx.Policies.ToList()
                    join Customer c in insctx.Customers.ToList()  on p.CustomerId equals c.PhoneNo
                    join Vehicle v in insctx.Vehicles.ToList() on p.VehicleId equals v.VehicleId
                    
                   
                    select new { c.Name,p.PolicyNo,p.StartDate,p.ExpiryDate,p.SumAssured,v.RegNo};


            var json = new JavaScriptSerializer().Serialize(data);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}