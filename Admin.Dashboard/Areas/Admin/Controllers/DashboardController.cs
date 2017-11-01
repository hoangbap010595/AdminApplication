using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Dashboard.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrators")]
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}