using System.Web.Mvc;

namespace Admin.Dashboard.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
               name: "Admin_Dashboard",
               url: "Admin/Dashboard/{action}/{id}",
               defaults: new { controller = "Dashboard", action = "Dashboard", id = UrlParameter.Optional }
                , namespaces: new[] { "Admin.Dashboard.Areas.Admin.Controllers" }
            );
        }
    }
}