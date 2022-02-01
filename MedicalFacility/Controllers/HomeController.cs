using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicalFacility.Models;

namespace MedicalFacility.Controllers
{
    public class HomeController : Controller
        
    {
        Model1 db = new Model1();
        public ActionResult IndexCustomer()
        {
            return View();
        }
        public ActionResult IndexAdmin()

        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LoginAdmin()
        {
           
           return View();
        }
        
       [HttpPost]
        public ActionResult LoginAdmin(Admin a)
        {
            int Result = db.Admins.Where(x => x.Admin_Email == a.Admin_Email && x.Admin_Password == a.Admin_Password).Count();  
           return View();
        }
    }
}