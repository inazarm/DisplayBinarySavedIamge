using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DisplayBinarySavedIamge.Models;

namespace DisplayBinarySavedIamge.Controllers
{
    public class HomeController : Controller
    {
        CAPSEntities db = new CAPSEntities();
        public ActionResult Index()
        {
            List<tblStudent> list = new List<tblStudent>();
            list= db.tblStudents.Where(x=>x.RegistrationNo==2305).ToList();
            foreach (var item in list)
            {
                ViewBag.img = item.Picture;
            }
            
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
    }
}