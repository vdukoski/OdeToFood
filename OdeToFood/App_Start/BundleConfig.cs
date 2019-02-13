using System.Web;
using System.Web.Optimization;

namespace OdeToFood
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            bundles.Add(new ScriptBundle("~/bundles/otf").Include(
                     "~/Scripts/jquery-3.3.1.js",
                     "~/Scripts/jquery-ui.js",
                     "~/Scripts/jquery.unobtrusive*",
                     "~/Scripts/jquery.validate*",
                     "~/Scripts/otf.js"
                ));

=======
>>>>>>> parent of 13c88de... added paging
=======
>>>>>>> parent of 13c88de... added paging
=======
>>>>>>> parent of 13c88de... added paging
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/jqueryui/jquery-ui.structure.css",
                      "~/Content/jqueryui/jquery-ui.theme.css",
                      "~/Content/site.css"));
        }
    }
}
