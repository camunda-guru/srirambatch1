using InsuranceService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace InsuranceService.Controllers
{
    public class CustomersController : Controller
    {
        private InsuranceContext insctx;

        // GET: Customers
        public ActionResult Index()
        {
            insctx = new InsuranceContext();
            var data = from Customer c in insctx.Customers.ToList()
                       join Policy p in insctx.Policies.ToList() on c.PhoneNo equals p.CustomerId
                       select new { c.Name, c.PhoneNo, p.PolicyNo, p.StartDate, p.ExpiryDate, p.SumAssured };
                       

            var json = new JavaScriptSerializer().Serialize(data);
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}