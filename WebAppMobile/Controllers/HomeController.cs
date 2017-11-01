using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMobile.Controllers
{
    [AuthorizeController]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ReflectionController refl = new ReflectionController();
            List<Type> ctrls = refl.GetControllers("WebAppMobile.Controllers");
            string rs = "<ul>";
            foreach (Type item in ctrls)
            {
                rs += "<li>" + item.Name;
                List<string> lsAction = refl.GetActions(item);
                rs += "<ul>";
                foreach (string ac in lsAction)
                {
                    rs += "<li>" + ac + "</li>";
                }
                rs += "</ul></li>";
            }
            rs += "<ul>";
            ViewBag.Ctrl = rs;
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