using System.Web;
using System.Web.Optimization;

namespace WebAppSchedule
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
            
                //call the bundle name here for step2 -------------------------------
                bundles.Add(new StyleBundle("~/Content/css2").Include(
                        "~/Content/StyleLayout2.css",
                        "~/Content/bootstrap.css",
                        "~/Content/jquery-ui.css",//new calendar.
                        "~/Content/jquery-ui.theme.min.css",//new calendar.
                        "~/Content/jquery-ui.theme.css",//new calendar.
                        "~/Content/jquery-ui.structure.min.css",//new calendar.
                        "~/Content/jquery-ui.structure.css"));//new calendar.

                //This is the script page bundle called stepsScripts.
                bundles.Add(new ScriptBundle("~/bundles/stepsScripts").Include(
                            "~/Scripts/modernizr-*",
                            "~/Scripts/jquery-1.10.2.js",
                            "~/Scripts/moment.js",
                            "~/Scripts/bootstrap.js",
                            "~/Scripts/jquery.validate.js",
                            "~/Scripts/Calendar.js",
                            "~/Scripts/jquery.validate.unobtrusive.js",
                            "~/Scripts/jquery-ui.js"));
            }
        }
    }
