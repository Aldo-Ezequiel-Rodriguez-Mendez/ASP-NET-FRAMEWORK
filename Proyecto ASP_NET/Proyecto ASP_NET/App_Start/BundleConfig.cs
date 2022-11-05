using System.Web;
using System.Web.Optimization;

namespace Proyecto_ASP_NET
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootstrap.min.js"
                        //"~/scripts/bootbox.js",
                        //"~/Scripts/respond.js",
                        //"~/scripts/datatables/jquery.datatables.js",
                        //"~/scripts/datatables/datatables.bootstrap.js",
                        //"~/scripts/typeahead.bundle.js",
                        //"~/scripts/toastr.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css"
                      //"~/Content/bootstrap-lumen.css",
                      //"~/Content/bootstrap-theme.css",
                      //"~/content/datatables/css/datatables.bootstrap.css",
                      //"~/content/typeahead.css",
                      //"~/content/toastr.css",
                      //"~/Content/site.css"
                      ));
        }

    }
}