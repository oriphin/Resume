using System.Web;
using System.Web.Optimization;

namespace Resume
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/lib/jquery-{version}.min.js",
                        "~/lib/jquery.ui.map.full.min.js",
                        "~/lib/jquery.scrollTo-1.4.3.1-min.js",
                        "~/lib/jquery.localscroll-1.2.7-min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/lib/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/lib/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/lib/angular.min.js").Include(
                "~/lib/angular-sanitize.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/app/app.js").Include(
                "~/app/directives.js").Include(
                "~/app/filters.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/bootstrap-responsive.css"));
        }
    }
}
