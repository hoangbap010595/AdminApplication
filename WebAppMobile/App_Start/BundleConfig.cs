using System.Web;
using System.Web.Optimization;

namespace WebAppMobile
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));        

            bundles.Add(new StyleBundle("~/Content/page").Include(
                      "~/Assets/plugins/bootstrap/css/bootstrap.css"
                      , "~/Assets/plugins/node-waves/waves.css"
                      , "~/Assets/plugins/animate-css/animate.css"
                      , "~/Assets/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/page").Include(
                     "~/Assets/plugins/jquery/jquery.min.js"
                    // , "~/Assets/plugins/jquery-validation/jquery.validate.js"
                     , "~/Assets/plugins/bootstrap/js/bootstrap.js"
                     , "~/Assets/plugins/node-waves/waves.js"
                     , "~/Assets/js/admin.js"));

            bundles.Add(new ScriptBundle("~/bundles/masterial").Include(
                       //Jquery Core Js
                      "~/Assets/plugins/jquery/jquery.min.js"
                      //Bootstrap Core Js
                      , "~/Assets/plugins/bootstrap/js/bootstrap.js"
                      //Select Plugin Js
                      , "~/Assets/plugins/bootstrap-select/js/bootstrap-select.js"
                      //Slimscroll Plugin Js
                      , "~/Assets/plugins/jquery-slimscroll/jquery.slimscroll.js"
                      //Waves Effect Plugin Js
                      , "~/Assets/plugins/node-waves/waves.js"
                      //Jquery CountTo Plugin Js
                      , "~/Assets/plugins/jquery-countto/jquery.countTo.js"
                      //Morris Plugin Js
                      , "~/Assets/plugins/raphael/raphael.min.js"
                      , "~/Assets/plugins/morrisjs/morris.js"
                      //ChartJs
                      , "~/Assets/plugins/chartjs/Chart.bundle.js"
                      //Flot Charts Plugin Js
                      , "~/Assets/plugins/flot-charts/jquery.flot.js"
                      , "~/Assets/plugins/flot-charts/jquery.flot.resize.js"
                      , "~/Assets/plugins/flot-charts/jquery.flot.pie.js"
                      , "~/Assets/plugins/flot-charts/jquery.flot.categories.js"
                      , "~/Assets/plugins/flot-charts/jquery.flot.time.js"
                      //Sparkline Chart Plugin Js
                      , "~/Assets/plugins/jquery-sparkline/jquery.sparkline.js"
                      //Custom Js
                      , "~/Assets/js/admin.js"
                      , "~/Assets/js/pages/index.js"
                      //Demo Js
                      , "~/Assets/js/demo.js"));

            bundles.Add(new StyleBundle("~/Content/masterial").Include(
                      "~/Assets/plugins/bootstrap/css/bootstrap.css"
                      , "~/Assets/plugins/node-waves/waves.css"
                      , "~/Assets/plugins/animate-css/animate.css"
                      , "~/Assets/plugins/morrisjs/morris.css"
                      , "~/Assets/css/style.css"
                      , "~/Assets/css/themes/all-themes.css"));
        }
    }
}
